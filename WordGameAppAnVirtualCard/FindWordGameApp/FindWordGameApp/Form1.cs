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

namespace FindWordGameApp
{
    public partial class Form1 : Form
    {
        List<string> wordList;

        User user = new User();
        public Form1()
        {
            InitializeComponent();
            wordList = new List<string>();
        }

        // Game End
        private bool isEnded = true;

        // Game Count 
        private int selectGameCaunt = 0;
        
        // Word List Index
        private int listindex = 0;
        
        private int gameCaunt = 0;


        private int guessCount = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 7; i++)
            {
                combGameCount.Items.Add(i);
            }
            combGameCount.DropDownStyle = ComboBoxStyle.DropDownList;
            combGameCount.SelectedIndex = 0;
        }

        private void btnSelectCount_Click(object sender, EventArgs e)
        {
            if (isEnded)
            {
                // 
                selectGameCaunt = int.Parse(combGameCount.SelectedItem.ToString());

                GenerateWord generate = new GenerateWord();
                wordList = generate.RadomSelectWords(selectGameCaunt+1, 2);
                user.CommonGameCount = selectGameCaunt;

                // Clear
                isEnded = false;


                labelWord.Text = wordList[listindex].Split(',')[0];

                setTimeout(EndGame, 12000);
            }
            else
                MessageBox.Show("Game Not Ended ! Plase Cantinue","Warrning",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }



        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!isEnded )
            {
                if (gameCaunt < selectGameCaunt)
                {

                    string guessWord = textGuessWord.Text.Trim();
                    string trueWord = wordList[listindex].Split(',')[1];
                    if (guessWord.ToLower() == trueWord.ToLower())
                    {
                        ++user.TrueWords;
                        ++listindex;
                        ++gameCaunt;
                        if (guessCount == 1)
                        {
                            user.Score += 6;
                        }
                        else if (guessCount == 2)
                        {
                            user.Score += 4;
                        }
                        else
                        {
                            user.Score += 2;
                        }
                        MessageBox.Show("Good Boy This True", "Congurlate",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (gameCaunt < selectGameCaunt)
                        {
                            labelWord.Text = wordList[listindex].Split(',')[0];
                        }
                        else
                            EndGame();
                    }
                    else
                    {
                        ++guessCount;
                        if (guessCount > 3)
                        {
                            ++user.FalseWords;
                            user.userFalseWords.Add(wordList[listindex]);
                            ++listindex;
                            ++gameCaunt;
                            if (gameCaunt < selectGameCaunt)
                            {
                                labelWord.Text = wordList[listindex].Split(',')[0];
                            }
                            else
                            {
                                EndGame();
                                return;
                            }

                            guessCount = 1;
                        }
                        MessageBox.Show("Bad Boy This False", "Congurlate",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                    EndGame();

            }
            else
                MessageBox.Show("Game Not Ended ! Plase Cantinue", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            // Error Game Ended
        }



        

        private void EndGame()
        {
            isEnded = true;
            UserInformation userinformation = new UserInformation(user);
            userinformation.ShowDialog();
            EndClear();
        }

        private void EndClear()
        {
            // Clear
            listindex = 0;
            isEnded = true;
            gameCaunt = 0;
            guessCount = 1;
            wordList.Clear();
            labelWord.Text = "Word";

            UserClear();
        }

        private void UserClear()
        {
            user.userFalseWords.Clear();
            user.Score = 0;
            user.CommonGameCount = 0;
            user.FalseWords = 0;
            user.TrueWords = 0;
        }

        public static void setTimeout(Action TheAction, int Timeout)
        {
            Thread t = new Thread(
                () =>
                {
                    Thread.Sleep(Timeout);
                    TheAction.Invoke();
                }
            );
            t.Start();
        }
    }
}
