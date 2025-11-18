using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2___Flipping_Cards_Game
{
     public partial class Form1 : Form
     {
          int Count = 0;
          bool SelectFirstCard = false;
           int [] LockedList = new int[12];
          bool MyHide = false;
    
          // bool SelectSecondCard = false;
          stPairsCards PairsCards = new stPairsCards();

          public Form1()
          {
               InitializeComponent();
          }

          struct stPairsCards
          {
               public Button btn1;
               public Button btn2;
 
          };

          private bool NumberIsFoundTwice(int[] Array, int Number)
          {
               int Count = 0;
               for (int i = 0; i < Array.Length; i++)
               {
                    if (Array[i] == Number)
                    {
                         Count++;
                    }
               }
               if (Count > 1)
                    return true;
               else
               {
                    /*Count = 0;
                    for (int i = 0; i < 11; i++)
                    {
                         if (Array[i] == Number)
                         {
                              Count++;
                         }
                    }*/
               return false;
          }
          }
          private void SetNumbers()
          {
               Random rnd = new Random();
               int[] Numbers;
               Numbers = new int[6];
               for (int i = 0; i < 6; i++)
               {
                    int Number = rnd.Next(1, 100);
                    while (NumberIsFoundTwice(Numbers, Number))
                         Number = rnd.Next(1, 100);
                    Numbers[i] = Number;
               }

               int []DoubleNumberes;
               DoubleNumberes = new int[12];

               for (int i = 0; i < 12; i = i + 2)
               {
                    int Number1 ;
                    int Number2 ;
                    do
                    {
                         Number1 = Numbers[rnd.Next(0, 6)];
                    }
                    while (NumberIsFoundTwice(DoubleNumberes, Number1));

                    DoubleNumberes[i] = Number1;

                    do
                    {
                         Number2 = Numbers[rnd.Next(0, 6)];
                    } while (NumberIsFoundTwice(DoubleNumberes, Number2));

                         DoubleNumberes[i+1] = Number2;

               }

               btn1.Tag = DoubleNumberes[0].ToString();
               btn2.Tag = DoubleNumberes[1].ToString();
               btn3.Tag = DoubleNumberes[2].ToString();
               btn4.Tag = DoubleNumberes[3].ToString();
               btn5.Tag = DoubleNumberes[4].ToString();
               btn6.Tag = DoubleNumberes[5].ToString();
               btn7.Tag = DoubleNumberes[6].ToString();
               btn8.Tag = DoubleNumberes[7].ToString();
               btn9.Tag = DoubleNumberes[8].ToString();
               btn10.Tag = DoubleNumberes[9].ToString();
               btn11.Tag = DoubleNumberes[10].ToString();
               btn12.Tag = DoubleNumberes[11].ToString();

          }


          private void ShowCard(Button btn)
          {

               btn.Text = btn.Tag.ToString();
               btn.BackColor = Color.Transparent;
               btn.ForeColor = Color.Black;
          }
          private void ShowAllCard()
          {

               ShowCard(btn1);
               ShowCard(btn2);
               ShowCard(btn3);
               ShowCard(btn4);
               ShowCard(btn5);
               ShowCard(btn6);
               ShowCard(btn7);
               ShowCard(btn8);
               ShowCard(btn9);
               ShowCard(btn10);
               ShowCard(btn11);
               ShowCard(btn12);
          }

          private void HideCard(Button btn)
          {

               btn.Text = "?";
               btn.BackColor = Color.FromArgb(192, 255, 192);
               btn.ForeColor = Color.White;
          }

          private void HideAllCard()
          {

               HideCard(btn1);
               HideCard(btn2);
               HideCard(btn3);
               HideCard(btn4);
               HideCard(btn5);
               HideCard(btn6);
               HideCard(btn7);
               HideCard(btn8);
               HideCard(btn9);
               HideCard(btn10);
               HideCard(btn11);
               HideCard(btn12);
          }

          private bool CompareCards(string FirstValue, string  SecondValue)
          {
               if(FirstValue==SecondValue)
               {
                    return true;
               }
               else
                    return false;
          }

          private bool CheckIfLockedButton(Button btn)
          {           
               
                    for (int i = 0; i < LockedList.Length; i++)
                    {
                         if (Convert.ToChar(btn.TabIndex) == LockedList[i])
                         {
                         return true;
                         }
                    }

                    return false;
         

          }
          private void btn_Click(object sender, EventArgs e)
          {
               if (!CheckIfLockedButton((Button)sender) && MyHide == true)
               {
                    if (SelectFirstCard == false )
                    {
                         //PairsCards.btn1.TabIndex = ((Button)sender).TabIndex;
                         PairsCards.btn1 = (Button)sender;
                         SelectFirstCard = true;
                         ShowCard(((Button)sender));

                    }
                    else
                    {
                         if (PairsCards.btn1.TabIndex.ToString() == ((Button)sender).TabIndex.ToString())
                         {

                              HideCard((Button)sender);
                              SelectFirstCard = false;
                       
                              PairsCards.btn1 = default;
                              PairsCards.btn2 = default;


                         }
                         else
                         {

                              //PairsCards.btn2.TabIndex = ((Button)sender).TabIndex;
                              PairsCards.btn2 = (Button)sender;

                              if (CompareCards(PairsCards.btn1.Tag.ToString(), PairsCards.btn2.Tag.ToString()))
                              {
                                   ShowCard(((Button)sender));
                                   LockedList[Count++] = PairsCards.btn1.TabIndex;
                                   LockedList[Count++] = PairsCards.btn2.TabIndex;

                                   SelectFirstCard = false;

                              }
                              else
                              {
                                   HideCard(PairsCards.btn1);
                                   HideCard(PairsCards.btn2);
                                   SelectFirstCard = false;

                              }
                              PairsCards.btn1 = default;
                              PairsCards.btn2 = default;


                         }
                    }

               }
          }

          private void Form1_Load(object sender, EventArgs e)
          {
               btnSetCards_Click(sender, e);
          }
          private void btnSetCards_Click(object sender, EventArgs e)
          {
               SetNumbers();
               ShowAllCard();


          }

          private void btnHideCards_Click(object sender, EventArgs e)
          {
               HideAllCard();
               MyHide = true;
               LockedList = new int[12];
               Count = 0;

          }

          private void btnResetGame_Click(object sender, EventArgs e)
          {
               btnHideCards_Click(sender,e);
               btnSetCards_Click(sender,e);
               ShowAllCard();

                Count = 0;
                SelectFirstCard = false;
               LockedList = new int[12];

               // bool SelectSecondCard = false;
                PairsCards = new stPairsCards();
               MyHide = false;

          }
     }
}
