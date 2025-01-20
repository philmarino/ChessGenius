using System.Drawing;

namespace ChessGenius1
{
    public partial class Form1 : Form
    {
        private readonly Color BlackColor = Color.SandyBrown;
        private readonly Color WhiteColor = Color.White;

        const string ImageRoot = @"C:\Git\ChessGenius1\Images";
        const string BlackBishop = "black-bishop.png";
        const string BlackKing = "black-king.png";
        const string BlackKnight = "black-knight.png";
        const string BlackPawn = "black-pawn.png";
        const string BlackQueen = "black-queen.png";
        const string BlackRook = "black-rook.png";
        const string WhiteBishop = "white-bishop.png";
        const string WhiteKing = "white-king.png";
        const string WhiteKnight = "white-knight.png";
        const string WhitePawn = "white-pawn.png";
        const string WhiteQueen = "white-queen.png";
        const string WhiteRook = "white-rook.png";

        public Form1()
        {
            InitializeComponent();

            //color the squares
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    bool isLightSquare = (row + col) % 2 == 0;
                    SetBackColor((row * 8) + col, (isLightSquare ? WhiteColor : BlackColor));
                }
            }
        }

        public void Draw(Board board)
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    int square = (row * 8) + col;
                    SetPiece(square, board.Square[square]);
                }
            }
        }

        public void SetBackColor(int square, Color color)
        {
            Square(square).BackColor = color;
        }

        public void SetPiece(int square, int piece)
        {
            Bitmap? _bitmap = piece switch
            {
                Piece.Black | Piece.Bishop => new Bitmap(new Bitmap(Path.Combine(ImageRoot, BlackBishop)), 64, 64),
                Piece.Black | Piece.King => new Bitmap(new Bitmap(Path.Combine(ImageRoot, BlackKing)), 64, 64),
                Piece.Black | Piece.Knight => new Bitmap(new Bitmap(Path.Combine(ImageRoot, BlackKnight)), 64, 64),
                Piece.Black | Piece.Pawn => new Bitmap(new Bitmap(Path.Combine(ImageRoot, BlackPawn)), 64, 64),
                Piece.Black | Piece.Queen => new Bitmap(new Bitmap(Path.Combine(ImageRoot, BlackQueen)), 64, 64),
                Piece.Black | Piece.Rook => new Bitmap(new Bitmap(Path.Combine(ImageRoot, BlackRook)), 64, 64),
                Piece.White | Piece.Bishop => new Bitmap(new Bitmap(Path.Combine(ImageRoot, WhiteBishop)), 64, 64),
                Piece.White | Piece.King => new Bitmap(new Bitmap(Path.Combine(ImageRoot, WhiteKing)), 64, 64),
                Piece.White | Piece.Knight => new Bitmap(new Bitmap(Path.Combine(ImageRoot, WhiteKnight)), 64, 64),
                Piece.White | Piece.Pawn => new Bitmap(new Bitmap(Path.Combine(ImageRoot, WhitePawn)), 64, 64),
                Piece.White | Piece.Queen => new Bitmap(new Bitmap(Path.Combine(ImageRoot, WhiteQueen)), 64, 64),
                Piece.White | Piece.Rook => new Bitmap(new Bitmap(Path.Combine(ImageRoot, WhiteRook)), 64, 64),
                Piece.None => null,
                _ => throw new Exception("No such piece " + piece),
            };

            Square(square).Image = _bitmap;
        }

        public void Clicked(int square)
        {
            SetBackColor(square, Color.Red);
        }

        private PictureBox Square(int square)
        {
            return square switch
            {
                0 => PictureBox1,
                1 => PictureBox2,
                2 => PictureBox3,
                3 => PictureBox4,
                4 => PictureBox5,
                5 => PictureBox6,
                6 => PictureBox7,
                7 => PictureBox8,
                8 => PictureBox9,
                9 => PictureBox10,
                10 => PictureBox11,
                11 => PictureBox12,
                12 => PictureBox13,
                13 => PictureBox14,
                14 => PictureBox15,
                15 => PictureBox16,
                16 => PictureBox17,
                17 => PictureBox18,
                18 => PictureBox19,
                19 => PictureBox20,
                20 => PictureBox21,
                21 => PictureBox22,
                22 => PictureBox23,
                23 => PictureBox24,
                24 => PictureBox25,
                25 => PictureBox26,
                26 => PictureBox27,
                27 => PictureBox28,
                28 => PictureBox29,
                29 => PictureBox30,
                30 => PictureBox31,
                31 => PictureBox32,
                32 => PictureBox33,
                33 => PictureBox34,
                34 => PictureBox35,
                35 => PictureBox36,
                36 => PictureBox37,
                37 => PictureBox38,
                38 => PictureBox39,
                39 => PictureBox40,
                40 => PictureBox41,
                41 => PictureBox42,
                42 => PictureBox43,
                43 => PictureBox44,
                44 => PictureBox45,
                45 => PictureBox46,
                46 => PictureBox47,
                47 => PictureBox48,
                48 => PictureBox49,
                49 => PictureBox50,
                50 => PictureBox51,
                51 => PictureBox52,
                52 => PictureBox53,
                53 => PictureBox54,
                54 => PictureBox55,
                55 => PictureBox56,
                56 => PictureBox57,
                57 => PictureBox58,
                58 => PictureBox59,
                59 => PictureBox60,
                60 => PictureBox61,
                61 => PictureBox62,
                62 => PictureBox63,
                63 => PictureBox64,
                _ => throw new Exception("There is no square " + square),
            };
        }

        #region PictureBoxes
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Clicked(0);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Clicked(1);
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Clicked(2);
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Clicked(3);
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Clicked(4);
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            Clicked(5);
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            Clicked(6);
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            Clicked(7);
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            Clicked(8);
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            Clicked(9);
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            Clicked(10);
        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            Clicked(11);
        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {
            Clicked(12);
        }

        private void PictureBox14_Click(object sender, EventArgs e)
        {
            Clicked(13);
        }

        private void PictureBox15_Click(object sender, EventArgs e)
        {
            Clicked(14);
        }

        private void PictureBox16_Click(object sender, EventArgs e)
        {
            Clicked(15);
        }

        private void PictureBox17_Click(object sender, EventArgs e)
        {
            Clicked(16);
        }

        private void PictureBox18_Click(object sender, EventArgs e)
        {
            Clicked(17);
        }

        private void PictureBox19_Click(object sender, EventArgs e)
        {
            Clicked(18);
        }

        private void PictureBox20_Click(object sender, EventArgs e)
        {
            Clicked(19);
        }

        private void PictureBox21_Click(object sender, EventArgs e)
        {
            Clicked(20);
        }

        private void PictureBox22_Click(object sender, EventArgs e)
        {
            Clicked(21);
        }

        private void PictureBox23_Click(object sender, EventArgs e)
        {
            Clicked(22);
        }

        private void PictureBox24_Click(object sender, EventArgs e)
        {
            Clicked(23);
        }

        private void PictureBox25_Click(object sender, EventArgs e)
        {
            Clicked(24);
        }

        private void PictureBox26_Click(object sender, EventArgs e)
        {
            Clicked(25);
        }

        private void PictureBox27_Click(object sender, EventArgs e)
        {
            Clicked(26);
        }

        private void PictureBox28_Click(object sender, EventArgs e)
        {
            Clicked(27);
        }

        private void PictureBox29_Click(object sender, EventArgs e)
        {
            Clicked(28);
        }

        private void PictureBox30_Click(object sender, EventArgs e)
        {
            Clicked(29);
        }

        private void PictureBox31_Click(object sender, EventArgs e)
        {
            Clicked(30);
        }

        private void PictureBox32_Click(object sender, EventArgs e)
        {
            Clicked(31);
        }

        private void PictureBox33_Click(object sender, EventArgs e)
        {
            Clicked(32);
        }

        private void PictureBox34_Click(object sender, EventArgs e)
        {
            Clicked(33);
        }

        private void PictureBox35_Click(object sender, EventArgs e)
        {
            Clicked(34);
        }

        private void PictureBox36_Click(object sender, EventArgs e)
        {
            Clicked(35);
        }

        private void PictureBox37_Click(object sender, EventArgs e)
        {
            Clicked(36);
        }

        private void PictureBox38_Click(object sender, EventArgs e)
        {
            Clicked(37);
        }

        private void PictureBox39_Click(object sender, EventArgs e)
        {
            Clicked(38);
        }

        private void PictureBox40_Click(object sender, EventArgs e)
        {
            Clicked(39);
        }

        private void PictureBox41_Click(object sender, EventArgs e)
        {
            Clicked(40);
        }

        private void PictureBox42_Click(object sender, EventArgs e)
        {
            Clicked(41);
        }

        private void PictureBox43_Click(object sender, EventArgs e)
        {
            Clicked(42);
        }

        private void PictureBox44_Click(object sender, EventArgs e)
        {
            Clicked(43);
        }

        private void PictureBox45_Click(object sender, EventArgs e)
        {
            Clicked(44);
        }

        private void PictureBox46_Click(object sender, EventArgs e)
        {
            Clicked(45);
        }

        private void PictureBox47_Click(object sender, EventArgs e)
        {
            Clicked(46);
        }

        private void PictureBox48_Click(object sender, EventArgs e)
        {
            Clicked(47);
        }

        private void PictureBox49_Click(object sender, EventArgs e)
        {
            Clicked(48);
        }

        private void PictureBox50_Click(object sender, EventArgs e)
        {
            Clicked(49);
        }

        private void PictureBox51_Click(object sender, EventArgs e)
        {
            Clicked(50);
        }

        private void PictureBox52_Click(object sender, EventArgs e)
        {
            Clicked(51);
        }

        private void PictureBox53_Click(object sender, EventArgs e)
        {
            Clicked(52);
        }

        private void PictureBox54_Click(object sender, EventArgs e)
        {
            Clicked(53);
        }

        private void PictureBox55_Click(object sender, EventArgs e)
        {
            Clicked(54);
        }

        private void PictureBox56_Click(object sender, EventArgs e)
        {
            Clicked(55);
        }

        private void PictureBox57_Click(object sender, EventArgs e)
        {
            Clicked(56);
        }

        private void PictureBox58_Click(object sender, EventArgs e)
        {
            Clicked(57);
        }

        private void PictureBox59_Click(object sender, EventArgs e)
        {
            Clicked(58);
        }

        private void PictureBox60_Click(object sender, EventArgs e)
        {
            Clicked(59);
        }

        private void PictureBox61_Click(object sender, EventArgs e)
        {
            Clicked(60);
        }

        private void PictureBox62_Click(object sender, EventArgs e)
        {
            Clicked(61);
        }

        private void PictureBox63_Click(object sender, EventArgs e)
        {
            Clicked(62);
        }

        private void PictureBox64_Click(object sender, EventArgs e)
        {
            Clicked(63);
        }
        #endregion
    }
}
