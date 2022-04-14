using System.Text;

namespace Student
{
    public partial class Form1 : Form
    {
       GPA oGPAcal = new GPA();

        public Form1()
        {
            InitializeComponent();
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.Rows.Add();
            dataGridView1.Rows[i].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[i].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[i].Cells[2].Value = comboBox1.Text;
            dataGridView1.Rows[i].Cells[3].Value = textBoxGPA.Text;

            string input = this.textBoxGPA.Text;

            double dInput = Convert.ToDouble(input);
            oGPAcal.addGPA(dInput, Name);

            double gpax = oGPAcal.getGPAx();
            textBoxGPAx.Text = gpax.ToString();

            double max = oGPAcal.getMax();
            textBoxMax.Text = max.ToString();

            double min = oGPAcal.getMin();
            textBoxMin.Text = min.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

       


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Sturdent(*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);
                string readAllText = File.ReadAllText(openFileDialog.FileName);

                for (int i = 0; i < readAllLine.Length; i++)
                {
                    string studentRAW = readAllLine[i];
                    string[] studentSplited = studentRAW.Split(',');
                     
                    Sturdent student = new Sturdent (studentSplited[0], studentSplited[1], studentSplited[2] );

                    
                }
            }
        }

       

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strData = string.Empty;

            string filepath = string.Empty;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Sturdent (*.csv)|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName != string.Empty)
                {
                    filepath = saveFileDialog.FileName;

                    int row = this.dataGridView1.Rows.Count;

                    for (int i = 0; i <= row; i++)
                    {
                        int column = this.dataGridView1.Columns.Count;
                        for (int j = 0; j <= column; j++)
                            strData = this.dataGridView1.Rows[i].Cells[j].Value.ToString();
                        //ToDo save doate 
                    }


                    //save file
                    File.WriteAllText(saveFileDialog.FileName, strData, Encoding.UTF8);
                }
            }
        }
    }
}