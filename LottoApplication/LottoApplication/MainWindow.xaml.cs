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

namespace LottoApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int maxNumberRange = 0;
        int[] lottoNumbers = new int[7];


        public MainWindow()
        {
            InitializeComponent();
        }
        //checks if the random number exists already in the array
        private bool mtdCheckIfNumberExists(int newNumber)
        {
            bool exists = false;
            foreach (int number in lottoNumbers)
            {
                if (number == newNumber)
                {
                    exists = true;
                }
            }
            return exists;
        }
        //generates random numbers to be stored
        // in the array and then written to the text boxes
        private int mtdGenerateRandomNumber(int maxNumber)
        {
            int number = 0;
            Random random = new Random();
            number = random.Next(1, maxNumberRange);
            return number;
        }
        private void mtdStartApplication()
        {
            int arrayPosition = 0;//to store current array position
            int randomNumber = 0;
            lottoNumbers.Initialize();

            do
            {
                randomNumber = mtdGenerateRandomNumber(maxNumberRange);
                bool exists = mtdCheckIfNumberExists(randomNumber);
                if (!exists)//if the number is not currently in the array
                {
                    lottoNumbers[arrayPosition] = randomNumber;
                    arrayPosition++;
                }
            } while (arrayPosition < lottoNumbers.Length);
            mtdDisplayResults();

        }
        //displays the results in the
        //text boxes
        private void mtdDisplayResults()
        {
            tbxResult1.Text = lottoNumbers[0].ToString();
            tbxResult2.Text = lottoNumbers[1].ToString();
            tbxResult3.Text = lottoNumbers[2].ToString();
            tbxResult4.Text = lottoNumbers[3].ToString();
            tbxResult5.Text = lottoNumbers[4].ToString();
            tbxResult6.Text = lottoNumbers[5].ToString();
            tbxResultBonus.Text = lottoNumbers[6].ToString();
        }

        private void btnIrishLotto_Click(object sender, RoutedEventArgs e)
        {
            maxNumberRange = 52;
            mtdStartApplication();
           /* int check = 0;


            Random rand = new Random();

            int[] lotto = new int[7];



            for (int i = 0; i < lotto.Length;)
            {
                check = rand.Next(1, 47);
                while (!(lotto.Contains(check)))
                {

                    lotto[i] = check;
                    i++;

                }
                tbxResult1.Text = lotto[0].ToString();
                tbxResult2.Text = lotto[1].ToString();
                tbxResult3.Text = lotto[2].ToString();
                tbxResult4.Text = lotto[3].ToString();
                tbxResult5.Text = lotto[4].ToString();
                tbxResult6.Text = lotto[5].ToString();
                tbxResultBonus.Text = lotto[6].ToString();
            }*/
        }
    

        private void btnUKLotto_Click(object sender, RoutedEventArgs e)
        {
            maxNumberRange = 59;
            mtdStartApplication();
            /*int check = 0;


            Random rand = new Random();

            int[] lotto = new int[7];



            for (int i = 0; i < lotto.Length;)
            {
                check = rand.Next(1, 59);
                while (!(lotto.Contains(check)))
                {

                    lotto[i] = check;
                    i++;

                }
                tbxResult1.Text = lotto[0].ToString();
                tbxResult2.Text = lotto[1].ToString();
                tbxResult3.Text = lotto[2].ToString();
                tbxResult4.Text = lotto[3].ToString();
                tbxResult5.Text = lotto[4].ToString();
                tbxResult6.Text = lotto[5].ToString();
                tbxResultBonus.Text = lotto[6].ToString();
            }*/
        }

        private void bgtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}