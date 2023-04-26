using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocialTolerance
{
    enum CellTypes { Empty = 0, Red = 1, Blue = 2, Green = 3, Yellow = 4, Gray = 5 };


    public partial class Form1 : Form
    {
        CellTypes[,] theWorld;
        Size gridSize = new Size(60, 60);
        Random rng = new Random();

        int cellSize = 6;
        int peoples = 2;
        double tolerance = 0.50;

        //where the grid sits in the form
        int gridLocationX = 250;
        int gridLocationY = 0;

        //amount of each kind of cell
        int empty;
        int redPop;
        int bluePop;
        int greenPop;
        int yellowPop;
        int grayPop;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnterData();
            BuildTheWorld();
        }



        private void CalcHappy()
        {
            //int i = rng.Next(0, gridSize.Width);
            //int j = rng.Next(0, gridSize.Width);


            double neighbors = 0; //the number of neighbors to this cell
            double freinds = 0; //the number of neighbors to this cell that are the same color

            for (int i = 0; i < gridSize.Width; i++)
            {
                for (int j = 0; j < gridSize.Height; j++)
                {
                    if (theWorld[i, j] != CellTypes.Empty) //someone lives here
                    {
                        for (int x = i - 1; x <= i + 1; x++) //look left and right
                        {
                            for (int y = j - 1; y <= j + 1; y++)//look up and down
                            {

                                int xCell = 0;
                                int yCell = 0;


                                if (i == x && j == y)
                                    continue; //skip this cell
                                              //if x is over the edge go to the other side
                                xCell = (x + gridSize.Width) % gridSize.Width;
                                // y is over the top or bottom go to the other side
                                yCell = (y + gridSize.Width) % gridSize.Width;

                                if (theWorld[xCell, yCell] == theWorld[i, j])
                                {
                                    neighbors++;
                                    freinds++;
                                }
                                else if (theWorld[xCell, yCell] != CellTypes.Empty)
                                {
                                    neighbors++;
                                }



                            }
                        }

                        if (freinds / neighbors > tolerance)
                        {
                            Move(i, j);
                        }



                    }
                }
            }
            Invalidate();
            int a = 0;
        }

        private void Move(int i, int j)
        {
            int x;
            int y;


            do
            {
                x = rng.Next(gridSize.Width);
                y = rng.Next(gridSize.Height);
            } while (theWorld[x, y] != CellTypes.Empty);

            theWorld[x, y] = theWorld[i, j];
            theWorld[i, j] = CellTypes.Empty;
        }

        private void BuildTheWorld()
        {

            //temp
            int rA;
            int rB;

            //make all cells empty first
            for (int i = 0; i < gridSize.Width; i++)
                for (int j = 0; j < gridSize.Height; j++)
                    theWorld[i, j] = CellTypes.Empty;

            //create red cells    
            for (int i = 0; i < redPop; i++)
            {
                rA = rng.Next(0, gridSize.Width);
                rB = rng.Next(0, gridSize.Height);

                if (theWorld[rA, rB] == CellTypes.Empty)
                    theWorld[rA, rB] = CellTypes.Red;
                else
                    i--;
            }

            //create blue cells    
            for (int i = 0; i < bluePop; i++)
            {
                rA = rng.Next(0, gridSize.Width);
                rB = rng.Next(0, gridSize.Height);

                if (theWorld[rA, rB] == CellTypes.Empty)
                    theWorld[rA, rB] = CellTypes.Blue;
                else
                    i--;
            }

            //create green cells    
            for (int i = 0; i < greenPop; i++)
            {
                rA = rng.Next(0, gridSize.Width);
                rB = rng.Next(0, gridSize.Height);

                if (theWorld[rA, rB] == CellTypes.Empty)
                    theWorld[rA, rB] = CellTypes.Green;
                else
                    i--;
            }

            //create yellow cells    
            for (int i = 0; i < yellowPop; i++)
            {
                rA = rng.Next(0, gridSize.Width);
                rB = rng.Next(0, gridSize.Height);

                if (theWorld[rA, rB] == CellTypes.Empty)
                    theWorld[rA, rB] = CellTypes.Yellow;
                else
                    i--;
            }

            //create gray cells    
            for (int i = 0; i < grayPop; i++)
            {
                rA = rng.Next(0, gridSize.Width);
                rB = rng.Next(0, gridSize.Height);

                if (theWorld[rA, rB] == CellTypes.Empty)
                    theWorld[rA, rB] = CellTypes.Gray;
                else
                    i--;
            }

            //the correct amount of empty cells should be left
        }

        private void EnterData()
        {
            //stop the timer
            //timer1.Enabled = false;

            //create grid and array based on entered data
            gridSize = new Size((int)enterWidth.Value, (int)enterWidth.Value);

            if (gridSize.Height <= 85)
                ClientSize = new Size(gridLocationX + (gridSize.Width * cellSize), gridLocationY + (85 * cellSize));
            else
                ClientSize = new Size(gridLocationX + (gridSize.Width * cellSize), gridLocationY + (gridSize.Height * cellSize));

            theWorld = new CellTypes[gridSize.Width, gridSize.Height];

            //set tolerance
            tolerance = ((double)enterTolerance.Value) / 100;

            //temp variable for figuring the populations
            double numCells = gridSize.Width * gridSize.Height;

            //calulate the amount of empty cells there will be
            empty = Convert.ToInt32(numCells * ((double)enterEmpty.Value / 100));

            //calculate the amount of cells for each color
            redPop = Convert.ToInt32((numCells - empty) * ((double)enterRed.Value / 100));
            bluePop = Convert.ToInt32((numCells - empty) * ((double)enterBlue.Value / 100));
            greenPop = Convert.ToInt32((numCells - empty) * ((double)enterGreen.Value / 100));
            yellowPop = Convert.ToInt32((numCells - empty) * ((double)enterYellow.Value / 100));
            grayPop = Convert.ToInt32((numCells - empty) * ((double)enterGray.Value / 100));

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {


            for (int i = 0; i < gridSize.Width; i++)
            {
                for (int j = 0; j < gridSize.Height; j++)
                {
                    Rectangle rect = new Rectangle((i * cellSize) + gridLocationX, (j * cellSize) + gridLocationY, cellSize, cellSize);

                    Brush brush = Brushes.White;

                    if (theWorld[i, j] == 0)
                        brush = Brushes.White;
                    else if (theWorld[i, j] == CellTypes.Red)
                        brush = Brushes.Red;
                    else if (theWorld[i, j] == CellTypes.Blue)
                        brush = Brushes.Blue;
                    else if (theWorld[i, j] == CellTypes.Green)
                        brush = Brushes.Green;
                    else if (theWorld[i, j] == CellTypes.Yellow)
                        brush = Brushes.Yellow;
                    else if (theWorld[i, j] == CellTypes.Gray)
                        brush = Brushes.Gray;


                    e.Graphics.FillRectangle(brush, rect);

                    e.Graphics.DrawRectangle(Pens.Black, rect);


                }
            }
        }

        private void enterWidth_ValueChanged(object sender, EventArgs e)
        {
            EnterData();
            BuildTheWorld();
            Invalidate();
        }

        private void butReset_Click(object sender, EventArgs e)
        {
            EnterData();
            BuildTheWorld();
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CalcHappy();
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void butStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void butStep_Click(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }
    }
}
