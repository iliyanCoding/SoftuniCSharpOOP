using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private const double propMinValue = 0;
        private const string zeroOrNegativeArgException = "{0} cannot be zero or negative.";

        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
  
        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= propMinValue)
                {
                    throw new ArgumentException(String.Format(zeroOrNegativeArgException, nameof(this.Length)));
                }

                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= propMinValue)
                {
                    throw new ArgumentException(String.Format(zeroOrNegativeArgException, nameof(this.Width)));
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            private set
            {
                if (value <= propMinValue)
                {
                    throw new ArgumentException(String.Format(zeroOrNegativeArgException, nameof(this.Height)));
                }

                this.height = value;
            }
        }

        public double SurfaceArea()
            => (2 * this.Width * this.length) + (2 * this.Width * this.Height) + (2 * this.Length * this.Height);

        public double LateralSurfaceArea()
            => (2 * this.Width * this.Height) + (2 * this.Length * this.Height);

        public double Volume()
            => (this.Length * this.Height * this.Width);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {this.SurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {this.LateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {this.Volume():f2}");

            return sb.ToString().TrimEnd();
        }
    }
}
