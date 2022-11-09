//**********************************************************************************
//Programmer: Toton Liantoro
//CIT Number: CIT241675
//Software: Microsoft Visual Studio 2022 Community Edition. 
//Platform: Microsoft Windows 11 Home (64-Bit)
//Purpose: Comply Assessment 3 (Task No.2), Subject: Apply advanced object-oriented language skills 
//**********************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using System.Xml.Linq;

namespace Assessment3_Toton
{
    public partial class FrmTwo : Form
    {
        public FrmTwo()
        {
            InitializeComponent();
            this.Width = 700;
            this.Height = 500;
        }

        public class User
        //This class defines the three basic members and their attributes
        {
            public string Name { get; set; }
            public string Salt { get; set; }
            public string SaltedHashedPassword { get; set; }
            public string Amount { get; set; }

        }
        
        private static Dictionary<string, User> Users = new Dictionary<string, User>();
        


        public static bool CheckPassword(string username, string password)
        {
            if (!Users.ContainsKey(username))
                return false;

            User u = Users[username];

            return CheckPassword(password, u.Salt, u.SaltedHashedPassword);
        }

        //*********************************************************************************
        /*This method picks up the user details supplied by the method above,
          and compares the entered password (salted and hashed) with the hashed password
          in the dictionary.*/
        public static bool CheckPassword(string password, string salt, string hashedPassword)
        {
            string saltedhashedPassword = SaltAndHashedPassword(password, salt);

            return (saltedhashedPassword == hashedPassword); //Successful if True
        }

        //*********************************************************************************
        //This method generates a hash based on (password + salt)
        private static string SaltAndHashedPassword(string password, string salt)
        {
            using (SHA256 sha = SHA256.Create())
            {
                string saltedPassword = password + salt;

                return Convert.ToBase64String(sha.ComputeHash(Encoding.Unicode.GetBytes(saltedPassword)));
            }
        }
        //*********************************************************************************


        private void button3_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
        }

       

        private void btnCheckUsername_Click(object sender, EventArgs e)
        {
            string filename = "ATM.txt";
            List<User> users = new List<User>();
            //Dictionary<string, User> Users = new Dictionary<string, User>();
            List<string> lines = File.ReadAllLines(filename).ToList();
    
            foreach (var line in lines)
            {
                string[] entries = line.Split(',');
                User newUser = new User();
                newUser.Name = entries[0];
                newUser.Salt = entries[1];
                newUser.SaltedHashedPassword = entries[2];
                newUser.Amount = entries[3];
                users.Add(newUser);

            }

            lstBoxResult.Items.Clear();
            lstBoxResult.Items.Add ($"{txtBoxUsername.Text} is NOT correct username ");
            foreach (var account in users)
            {

                if (txtBoxUsername.Text == account.Name)
                {
                    lstBoxResult.Items.Clear();
                    lstBoxResult.Items.Add(txtBoxUsername.Text + " is corret username");
                }

            }

        }


        int clickCounter = 3;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            clickCounter --;
            if (clickCounter < 0) // arbitrary number
            {
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
            }



            string filename = "ATM.txt"; //This open and read source data ATM.txt
            List<User> users = new List<User>();
            //Dictionary<string, User> Users = new Dictionary<string, User>();
            List<string> lines = File.ReadAllLines(filename).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');
                User newUser = new User();
                newUser.Name = entries[0];
                newUser.Salt = entries[1];
                newUser.SaltedHashedPassword = entries[2];
                newUser.Amount = entries[3];
                users.Add(newUser);

            }

            var counter = clickCounter;
            lstBoxResult.Items.Clear();
            lstBoxResult.Items.Add($"Your login NOT Sucessfull..!!");
            lstBoxResult.Items.Add("");
            lstBoxResult.Items.Add($"You have {counter} chance(s) left to login");
            foreach (var account in users)
            {
                if ((txtBoxUsername.Text == account.Name) && (account.SaltedHashedPassword == SaltAndHashedPassword(txtBoxPassword.Text, account.Salt))){
                    clickCounter++;
                    lstBoxResult.Items.Clear();
                    lstBoxResult.Items.Add($"Welcome {account.Name}, You have succesfully login !!!");
                    lstBoxResult.Items.Add("");
                    lstBoxResult.Items.Add($"Your current balance is: ${account.Amount}");
                    clickCounter = 3;
                    




                }


            }


           


        }


    }
}
