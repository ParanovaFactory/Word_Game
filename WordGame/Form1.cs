using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int questionNo = 0, correct = 0, wrong = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Text = "Next Question"; questionNo++;
            this.Text = "Question: " + questionNo;
            if (questionNo == 1)
            {
                richTextBox1.Text = "Ülkeimizn güney kısmındaki kıyı bölgesi?";
                A.BackColor = Color.Yellow;
            }
            else if (questionNo == 2)
            {
                richTextBox1.Text = "Yeşil şehir?";
                B.BackColor = Color.Yellow;
            }
            else if (questionNo == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                C.BackColor = Color.Yellow;
            }
            else if (questionNo == 4)
            {
                richTextBox1.Text = "Karpuzu ile ünlü ilimiz?";
                D.BackColor = Color.Yellow;
            }
            else if (questionNo == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin karşıtı?";
                E.BackColor = Color.Yellow;
            }
            else if (questionNo == 6)
            {
                richTextBox1.Text = "Padişah emirlerinin yazılı hali?";
                F.BackColor = Color.Yellow;
            }
            else if (questionNo == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                G.BackColor = Color.Yellow;
            }
            else if (questionNo == 8)
            {
                richTextBox1.Text = "öğrencilerin kötü karne getirince yapıştığı nesne?";
                H.BackColor = Color.Yellow;
            }
            else if (questionNo == 9)
            {
                richTextBox1.Text = "Gülü ile ünlü ilimiz?";
                I.BackColor = Color.Yellow;
            }
            else if (questionNo == 10)
            {
                richTextBox1.Text = "Mersinin diğer adı?";
                İ.BackColor = Color.Yellow;
            }
            else if (questionNo == 11)
            {
                richTextBox1.Text = "Askeri topluluk?";
                J.BackColor = Color.Yellow;
            }
            else if (questionNo == 12)
            {
                richTextBox1.Text = "Malatyanın meşur meyvesi?";
                K.BackColor = Color.Yellow;
            }
            else if (questionNo == 13)
            {
                richTextBox1.Text = "Her yıl bahar ayında düzenlenen çiçek festivali?";
                L.BackColor = Color.Yellow;
            }
            else if (questionNo == 14)
            {
                richTextBox1.Text = "Yılın 3. ayı?";
                M.BackColor = Color.Yellow;
            }
            else if (questionNo == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzük aleti?";
                N.BackColor = Color.Yellow;
            }
            else if (questionNo == 16)
            {
                richTextBox1.Text = "Halk şairi?";
                O.BackColor = Color.Yellow;
            }
            else if (questionNo == 17)
            {
                richTextBox1.Text = "Prinç havuç gibi sebzelerle yapılan yemek?";
                P.BackColor = Color.Yellow;
            }
            else if (questionNo == 18)
            {
                richTextBox1.Text = "11 ayın sultanı?";
                R.BackColor = Color.Yellow;
            }
            else if (questionNo == 19)
            {
                richTextBox1.Text = "İngilizcede yılan?";
                S.BackColor = Color.Yellow;
            }
            else if (questionNo == 20)
            {
                richTextBox1.Text = "Türkiyenin mega starı?";
                T.BackColor = Color.Yellow;
            }
            else if (questionNo == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?";
                U.BackColor = Color.Yellow;
            }
            else if (questionNo == 22)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
                V.BackColor = Color.Yellow;
            }
            else if (questionNo == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
                Y.BackColor = Color.Yellow;
            }
            else if (questionNo == 24)
            {
                richTextBox1.Text = "Ege bölgesinin melhur meyvesi?";
                Z.BackColor = Color.Yellow;
            }
            else
            {
                richTextBox1.Text = "Contest completed";
            }

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (questionNo)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            A.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            A.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            B.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            B.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            C.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            C.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            D.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            D.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            E.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            E.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            F.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            F.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            G.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            G.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            H.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            H.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "Isparta")
                        {
                            I.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            I.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "İçel")
                        {
                            İ.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            İ.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            J.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            J.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            K.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            K.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            L.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            L.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "Mart")
                        {
                            M.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            M.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            N.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            N.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            O.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            O.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "pırasa")
                        {
                            P.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            P.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            R.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            R.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "snake")
                        {
                            S.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            S.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "Tarkan")
                        {
                            T.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            T.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "umut")
                        {
                            U.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            U.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "van")
                        {
                            V.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            V.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "yıldırım")
                        {
                            Y.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            Y.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "zeytin")
                        {
                            Z.BackColor = Color.Green;
                            correct++;
                            lblCorrect.Text = correct.ToString();
                        }
                        else
                        {
                            Z.BackColor = Color.Red;
                            wrong++;
                            lblWrong.Text = wrong.ToString();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}