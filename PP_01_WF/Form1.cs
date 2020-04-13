using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_01_WF
{
    public partial class Form1 : Form
    {
        private delegate void SafeCallDelegate(string text);
        public Form1()
        {
            InitializeComponent();
        }

        public static double h1;
        public double[] results;
        private struct Struct1
        {
            public double start;
            public double end;
            public int countN;
            public int countThread;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double start, end;
            int countN;
            start = 4;
            end = 10;
            countN = 3;
            results = new double[countN];
            Struct1 struct1 = new Struct1();
            struct1.start = start;
            struct1.end = end;
            struct1.countN = countN;
            struct1.countThread = 0;
            Thread thread = new Thread(devide);
            thread.Start(struct1);
        }

        private void devide(object struct1)
        {
            Struct1 struct2 = (Struct1)struct1;
            double start = struct2.start;
            double end = struct2.end;
            int countN = struct2.countN;
            devideCountN(start, end, countN);
            int countThread = 0;
            double endT = start + h1;
            Thread[] threads = new Thread[countN];

            for (double i = start; i < end; i += h1)
            {
                Struct1 struct3 = new Struct1();
                lock ((object)results)
                {
                    endT = i + h1;
                    if (endT > end) { endT = end; }
                    struct3.start = i;
                    struct3.end = endT;
                    struct3.countN = 10000;
                    struct3.countThread = countThread;
                    threads[countThread] = new Thread(calculator);
                    threads[countThread].Start(struct3);
                    countThread++;
                }
            }

            foreach (Thread t in threads)
            {
                t.Join();
            }

            double resultsAll = 0;
            
            for (int i = 0; i < countThread; i++) {
                resultsAll += results[i];
            }

            WriteTextSafe(resultsAll.ToString());

        }

        private void WriteTextSafe(string text)
        {
            if (LB_Result_Integral.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                LB_Result_Integral.Invoke(d, new object[] { text });
            }
            else
            {
                LB_Result_Integral.Text = text;
            }
        }

        private  void devideCountN(double start, double end, int countN)
        {
            h1 = Math.Round((end - start) / countN);
        }

        private  void calculator(object struct1)
        {
            double result = 0;
            Struct1 struct2 = (Struct1)struct1;
            double start = struct2.start;
            double end = struct2.end;
            int countN = struct2.countN;
            int countThread = struct2.countThread;
            results[countThread] = threadCalc(start, end, countN);
        }

        private double f(double x)
        {
            return Math.Pow(2, x) / Math.Pow(x, 3);
        }

        private double threadCalc(double start, double end, double countN)
        {
            double result = 0;
            double h = (end - start) / countN;
            int i;
            for (i = 0; i < countN; i++)
            {
                result += f(start + h * (i + 0.5));
            }
            result *= h;
            return result;
        }

    }
}
