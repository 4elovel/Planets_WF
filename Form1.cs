namespace Planets_WF
{
    public partial class Form1 : Form
    {
        int total = 0;

        enum Planets
        {
            �������=3,������=48,�����=59,����=6,�����=18980,������=5683,����=868,������=1024
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string planet = textBox1.Text;

            switch (planet)
            {
                case "�������":
                    total += (int)Planets.�������;
                    break;
                case "������":
                    total += (int)Planets.������;
                    break;
                case "�����":
                    total += (int)Planets.�����;
                    break;
                case "����":
                    total += (int)Planets.����;
                    break;
                case "�����":
                    total += (int)Planets.�����;
                    break;
                case "������":
                    total += (int)Planets.������;
                    break;
                case "����":
                    total += (int)Planets.����;
                    break;
                case "������":
                    total += (int)Planets.������;
                    break;
                default:
                    label2.Text = "������� �����";
                    return;
            }
            label2.Text = "������ ������";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = total + " * 10^23 ��";
        }
    }
}