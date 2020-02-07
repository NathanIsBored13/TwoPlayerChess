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

namespace TwoPlayerChess
{
    struct ImagePool
    {
        public BitmapImage BKing;
        public BitmapImage BQueen;
        public BitmapImage BBishop;
        public BitmapImage BRook;
        public BitmapImage BKnight;
        public BitmapImage BPawn;
        public BitmapImage WKing;
        public BitmapImage WQueen;
        public BitmapImage WBishop;
        public BitmapImage WRook;
        public BitmapImage WKnight;
        public BitmapImage WPawn;
    }
    static class Icons
    {
        public static ImagePool imagePool;
        public static void LoadPool(string folder)
        {
            imagePool = new ImagePool()
            {
                BKing = new BitmapImage(new Uri($@"{Environment.CurrentDirectory}\Resources\{folder}\BKing.png")),
                BQueen = new BitmapImage(new Uri($@"{Environment.CurrentDirectory}\Resources\{folder}\BQueen.png")),
                BBishop = new BitmapImage(new Uri($@"{Environment.CurrentDirectory}\Resources\{folder}\BBishop.png")),
                BRook = new BitmapImage(new Uri($@"{Environment.CurrentDirectory}\Resources\{folder}\BRook.png")),
                BKnight = new BitmapImage(new Uri($@"{Environment.CurrentDirectory}\Resources\{folder}\BKnight.png")),
                BPawn = new BitmapImage(new Uri($@"{Environment.CurrentDirectory}\Resources\{folder}\BPawn.png")),
                WKing = new BitmapImage(new Uri($@"{Environment.CurrentDirectory}\Resources\{folder}\WKing.png")),
                WQueen = new BitmapImage(new Uri($@"{Environment.CurrentDirectory}\Resources\{folder}\WQueen.png")),
                WBishop = new BitmapImage(new Uri($@"{Environment.CurrentDirectory}\Resources\{folder}\WBishop.png")),
                WRook = new BitmapImage(new Uri($@"{Environment.CurrentDirectory}\Resources\{folder}\WRook.png")),
                WKnight = new BitmapImage(new Uri($@"{Environment.CurrentDirectory}\Resources\{folder}\WKnight.png")),
                WPawn = new BitmapImage(new Uri($@"{Environment.CurrentDirectory}\Resources\{folder}\WPawn.png")),
            };
        }
    }
}
