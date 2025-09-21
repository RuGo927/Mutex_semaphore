using System;
using System.Threading;
using System.Windows.Forms;

namespace Mutex_semaphore
{
    public partial class Form1 : Form
    {
        private readonly object slotLock = new object();
        private int running = 0;               // artiv threadlar - slot sayını göstərir
        private int maxParallel = 1;              // max aktiv Thread sayısı - numericUpDown ilə dəyişəcək
        private int counter = 0;              // thread id - threadlerin ardicilligini göstərmək üçün
        private readonly int runDurationSeconds = 10; 

        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Clear();

            if (numericUpDown1.Minimum <= 0) numericUpDown1.Minimum = 1;
            if (numericUpDown1.Value < numericUpDown1.Minimum) numericUpDown1.Value = numericUpDown1.Minimum;
            maxParallel = (int)numericUpDown1.Value;

            numericUpDown1.ValueChanged += NumericUpDown1_ValueChanged;
            button2.Click += Button1_Click;
            listBox3.DoubleClick += ListBox3_DoubleClick;
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e) 
        {
            maxParallel = (int)numericUpDown1.Value;

            lock (slotLock)
            {
                Monitor.PulseAll(slotLock);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            counter++;
            string name = $"Thread {counter}";
            listBox3.Items.Add(name);
        }

        private void ListBox3_DoubleClick(object sender, EventArgs e)
        {
            if (listBox3.SelectedItem == null) return;
            string threadName = listBox3.SelectedItem.ToString();

            this.Invoke((MethodInvoker)(() =>
            {
                listBox3.Items.Remove(threadName);
                listBox2.Items.Add($"{threadName} - 3s gözləyir");
            }));

            Thread t = new Thread(() => StartAfterDelay(threadName)) { IsBackground = true };
            t.Start();
        }

        private void StartAfterDelay(string threadName)
        {
            Thread.Sleep(3000);

            lock (slotLock)
            {
                while (running >= maxParallel)
                {
                    Monitor.Wait(slotLock);
                }
                running++;
            }

            this.Invoke((MethodInvoker)(() =>
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    if (listBox2.Items[i].ToString().StartsWith(threadName))
                    {
                        listBox2.Items.RemoveAt(i);
                        break;
                    }
                }
                listBox1.Items.Add($"{threadName} - 0/{runDurationSeconds}");
            }));

            try
            {
                for (int s = 1; s <= runDurationSeconds; s++)
                {
                    Thread.Sleep(1000);

                    this.Invoke((MethodInvoker)(() =>
                    {
                        for (int i = 0; i < listBox1.Items.Count; i++)
                        {
                            if (listBox1.Items[i].ToString().StartsWith(threadName))
                            {
                                listBox1.Items[i] = $"{threadName} - {s}/{runDurationSeconds} ";
                                break;
                            }
                        }
                    }));
                }

                this.Invoke((MethodInvoker)(() =>
                {
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        if (listBox1.Items[i].ToString().StartsWith(threadName))
                        {
                            listBox1.Items[i] = $"{threadName} - tamamlandı ({runDurationSeconds}s)";
                            break;
                        }
                    }
                }));
            }
            finally
            {
                lock (slotLock)
                {
                    running--;
                    Monitor.PulseAll(slotLock);
                }
            }
        }
    }
}
