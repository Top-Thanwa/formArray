namespace formArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines;
            int[] numbers = new int[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                if (int.TryParse(data[i], out int number))
                {
                    numbers[i] = number;
                }
                else
                {
                    numbers[i] = 0;
                }
            }
             
            int min = 0,max = numbers[0];
            for(int i = 0; i < numbers.Length; i++)
            {
                if (min < numbers[i])
                {
                    min = numbers[i];
                }

                if (max > numbers[i])
                {
                    max = numbers[i];
                }
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            //double average = Convert.ToDouble(sum) / numbers.Length;
            double average = (double)sum / numbers.Length;

             lblCount.Text = "จำนวนสมาชิกข้อมูล : " + numbers.Length;
             lblSum.Text = "ผลรวม : " + sum;
             lblAgv.Text = "ค่าเฉลี่ย : " + average;
             lblMax.Text = "ค่าสูงสุด : " + max;
             lblMin.Text = "ค่าต่ำสุด : " + min;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[,] data = new string[5, 3]
            {
                {"ธันวา","ท๊อป","หนองคาย" },
                {"ณัฐภูมิ","น้อต","หนองคาย" },
                {"วัชชิระ","สเน็ค","อุดรธานี" },
                {"ภูริณัฐ","ทินนี่","อุดรธานี" },
                {"อินทิรา","เอ็มมี่","หนองคาย" }

            int row = data.GetLength(0);
            int col = data.GetLength(1);
            string result = "";
            for(int i = 0;i < row; i++)
            {
                result += "ข้อมูลที่ " + (i + 1) + " : ";
                result += "ชื่อจริง " + data[i, 0] + ", ";
                result += "ชื่อเล่น " + data[i, 1] + ", ";
                result += "จังหวัด " + data[i, 2] + "\n ";
            }
            label2.Text = result;

        }
    }
}
