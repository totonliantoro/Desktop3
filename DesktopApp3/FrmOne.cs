//**********************************************************************************
//Programmer: Toton Liantoro
//CIT Number: CIT241675
//Software: Microsoft Visual Studio 2022 Community Edition. 
//Platform: Microsoft Windows 11 Home (64-Bit)
//Purpose: Comply Assessment 3 (Task No.1), Subject: Apply advanced object-oriented language skills 
//**********************************************************************************



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment3_Toton
{

    public partial class FrmOne : Form
    {
        public FrmOne()
        {
            InitializeComponent();
            this.Width = 700;
            this.Height = 500;
        }


        //Implement Binary Tree

        public class Tree<TItem> where TItem : IComparable<TItem>
        {
            public TItem NodeData { get; set; } //The value inside the node
            public Tree<TItem> LeftTree { get; set; } //The branch that is the left sub-tree
            public Tree<TItem> RightTree { get; set; } //The branch that is the right sub-tree

            //Constructor
            public Tree(TItem nodeValue)
            {
                this.NodeData = nodeValue;
                this.LeftTree = null;
                this.RightTree = null;
            }

            //Insert value to tree
            public void Insert(TItem newItem)
            {
                TItem currentNodeValue = this.NodeData;

                if (currentNodeValue.CompareTo(newItem) > 0)
                {
                    //Insert new item into left subtree
                    if (this.LeftTree == null)
                    {
                        this.LeftTree = new Tree<TItem>(newItem); //Insert value here
                    }
                    else
                    {
                        this.LeftTree.Insert(newItem); //Keep going until we find a null
                    }
                }
                else
                {
                    //Insert item into right subtree
                    if (this.RightTree == null)
                    {
                        this.RightTree = new Tree<TItem>(newItem); //Insert value here
                    }
                    else
                    {
                        this.RightTree.Insert(newItem); //Keep going until we find a null
                    }
                }
            }


            public string WalkTree()
            {
                string result = "";

                //Walk the left tree first using the inorder method...           
                if (this.LeftTree != null)
                {
                    result = this.LeftTree.WalkTree(); //Add this node value to the result string
                }

                result += $" {this.NodeData.ToString()} ";

                //...then walk the right tree
                if (this.RightTree != null)
                {
                    result += this.RightTree.WalkTree(); //Add this node value to the result string
                }

                return result;
            }


        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Add(textBoxInput.Text);
            textBoxInput.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //check if item is selected, remove if selected
            if (displayListBox.SelectedIndex != -1)
                displayListBox.Items.RemoveAt(displayListBox.SelectedIndex);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            displayListBox.Items.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = displayListBox.Items.OfType<string>().ToArray();
            int[] arr1 = Array.ConvertAll(arr,int.Parse);
            Tree<int> tree1 = new Tree<int>(10);
            //displayListBox.Items.Clear();
            foreach (int item in arr1)
            {
                tree1.Insert(item);
                

            }
            string sortedData = tree1.WalkTree();
            listBoxResult.Items.Add("The sorted data is: "+ sortedData);
            listBoxResult.BackColor = System.Drawing.Color.LightCyan;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear();
        }

        private void FrmOne_Load(object sender, EventArgs e)
        {

        }

        private void FrmOne_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Black); //paint exterior
            Brush myBrush1 = new SolidBrush(Color.Red);

            
            g.FillRectangle(myBrush1, 200, 100, 17, 8);

            Point point1 = new Point(217, 90);
            Point point2 = new Point(217, 117);
            Point point3 = new Point(230, 103);
            Point[] myPoint = { point1, point2,point3};
            g.FillPolygon(myBrush1 , myPoint);



        }
    }



}
