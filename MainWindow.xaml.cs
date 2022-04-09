using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AOAOAOAO.Models;
namespace AOAOAOAO
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IKrip kripLeft;

        IKrip kripRigth;
        private void clear_button_Click(object sender, RoutedEventArgs e)
        {
            textBoxResult.Text = string.Empty;
        }
        public MainWindow()
        {
            InitializeComponent();
            //kripLeft = new Skeleton();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int damageSkeleton = int.Parse(this.textBoxDamageSkeleton.Text);
            int healthSkeleton = int.Parse(this.textBoxHealthSkeleton.Text);
            int damageUndead = int.Parse(this.textBoxDamageSkeleton.Text);
            int healthUndead = int.Parse(this.textBoxHealthSkeleton.Text);
            int damageSpearman = int.Parse(this.textBoxDamageSpearman.Text);
            int healthSpearman = int.Parse(this.textBoxHealthSpearman.Text);
            Spearman spearman1 = new Spearman(damageSpearman, healthSpearman);
            Skeleton skeleton1 = new Skeleton(damageSkeleton, healthSkeleton);
            Undead undead1 = new Undead(damageUndead, healthUndead);
            while (true)
            {
                //while(true). Если копейщик жив,он наносит урон, иначе победил скелет. Если скелет после нанесения урона жив,он отвечает копейщику, инаые победил копейщик
                if (!kripLeft.IsDead())
                {
                    damageSpearman = kripLeft.Storming();
                    kripRigth.LossOfHealth(damageSpearman);
                    textBoxResult.Text += "Копейщик атакует Скелета. Жизней у Скелета: " + IKrip.health + "\n\r";
                    if (!skeleton1.IsDead())
                    {
                        damageSpearman = skeleton1.Storming();
                        spearman1.LossOfHealth(damageSkeleton);
                        textBoxResult.Text += "Скелет атакует Копейщика. Жизней у Копейщика: " + spearman1.health + "\n\r";

                    }
                    else
                    {

                        textBoxResult.Text += "Выиграл Копейщик\n\r";
                        break;
                    }
                }
                else
                {
                    textBoxResult.Text += "Выиграл Скелетон\n\r";
                    break;
                }

            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChangedLeft(object sender, SelectionChangedEventArgs e)
        {
            string nameLeft = ((System.Windows.Controls.ContentControl)((System.Windows.Controls.Primitives.Selector)sender).SelectedItem).Content.ToString();
            switch (nameLeft)
            {
                case "Копейщик":
                    {
                        kripLeft = new Spearman();
                        break;
                    }
                case "Скелет":
                    {
                        kripLeft = new Skeleton();
                        break;
                    }
                case "Нежить":
                    {
                        kripLeft = new Undead();
                        break;
                    }
            }
        }
        private void ComboBox_SelectionChangedRight(object sender, SelectionChangedEventArgs e)
        {
            string nameRight = ((System.Windows.Controls.ContentControl)((System.Windows.Controls.Primitives.Selector)sender).SelectedItem).Content.ToString();
            switch (nameRight)
            {
                case "Копейщик":
                    {
                        kripLeft = new Spearman();
                        break;
                    }
                case "Скелет":
                    {
                        kripLeft = new Skeleton();
                        break;
                    }
                case "Нежить":
                    {
                        kripLeft = new Undead();
                        break;
                    }
            }
        }
    }
}
           
    

