using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Drawing;

namespace App2
{
    public class Entity
    {
        static int IDs = 0;
        static public int GetNewID()
        {
            return IDs++;
        }


        //*********\
        
        private int ID;
        private Point pntLocation;

        public Entity()
        {
            ID = GetNewID();
            pntLocation = new Point(0, 0);
        }
        public Entity(Point pnt)
        {
            ID = GetNewID();
            pntLocation = pnt;
        }
        public int GetID()
        {
            return ID;
        }
        public Point GetPosition()
        {
            return pntLocation;
        }
        public int GetPositionX()
        {
            return pntLocation.X;
        }
        public int GetPositionY()
        {
            return pntLocation.Y;
        }


    }

}