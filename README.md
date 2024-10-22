# Poker_Csharp

## 2024/10/22

### Poker

*撲克牌比大小

*功能
    1.按 Start 啟動計時器,計時器會以每0.05秒亂數切換Poker1~Poker13撲克牌圖。
    2.按 Stop 顯示點數及對應撲克牌圖
    
# 程式碼
```csharp=
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int point;
        int pointpc;
        Random rand = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            timer1.Interval = 100;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pointpc = rand.Next(13);
            pictureBox1.Image = imageList1.Images[pointpc];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (point > pointpc)
            {
                label3.Text = "You Won";
            }
            else if (point < pointpc)
            {
                label3.Text = "You Lost";
            }
            else
            {
                label3.Text = "Draw";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            point = rand.Next(13);
            pictureBox2.Image = imageList1.Images[point];
        }
    }
}
```
# 成果照
1. Draw
![image](https://hackmd.io/_uploads/SJ2fS6Nlye.png)
2. Won
![image](https://hackmd.io/_uploads/r1TjS6Nlyg.png)
3. Lost
![image](https://hackmd.io/_uploads/r1XTSpVe1l.png)
