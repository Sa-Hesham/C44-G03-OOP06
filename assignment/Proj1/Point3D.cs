using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Proj1
{
    internal class Point3D :IComparable ,ICloneable

    {

		private int x;

		public int X
		{
			get { return x; }
			set { x =  value<0? 0:value; }
		}

        private int y;

        public int Y
        {
            get { return y; }
            set {y = value<0? 0:value; }
        }

        private int z;

        public int Z
        {
            get { return z; }
            set { z= value <0? 0:value; }
        }

        public override string ToString()
        {
            return $"“Point Coordinates: ({X},{Y},{Z})”.";
        }

        public Point3D()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }
        public Point3D(int x ,int y ,int z)
        {
            this.X = x; 
            this.Y = y; 
            this.Z = z;
        }
        public Point3D( int x , int y) :this(x,y,0) 
        {
            
        }

        public Point3D(int x):this(x,0,0) 
        {
            
        }


       public static bool operator == (Point3D p1, Point3D p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
        }

        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return p1 != p2;
        }

     
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (GetType() != obj.GetType()) return false;

            Point3D p = (Point3D)obj;
            return this == p;
        }

        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;
            Point3D other = (Point3D)obj;
            int Comparex = this.X.CompareTo(other.X);
            if (Comparex != 0) return Comparex;
            else
            {
                return this.Y.CompareTo(other.Y);
            }
        }

        public object Clone()
        {
            return new Point3D()
            {
                X = this.X,
                Y = this.Y,
                Z = this.Z
            };
        }
    }
}

