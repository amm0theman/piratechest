using System;
using System.IO;
using System.Linq;

namespace seesharp {
    class Pond {
        int a;          //a x b is max box top area
        int b;
        int m;          //m x n is pond top area
        int n;

        int[,] pondDepths;    //Contains depths of pond at x,y

        public Pond() {

        }

        public Pond(string path) {
            loadPond_fromFile(path);
        }
        
        public Pond(int a, int b, int m, int n, int[,] pond) {
                this.a = a;
                this.b = b;
                this.m = m;
                this.n = n;
                this.pondDepths = pond;
        }

        public void loadPond_fromFile(string filepath) {
            string line;
            string[] dimensions = new string[4];

            using(System.IO.StreamReader fileReader = new System.IO.StreamReader(filepath)) {
                line = fileReader.ReadLine();
                dimensions = line.Split(' ');

                a = int.Parse(dimensions[0]);
                b = int.Parse(dimensions[1]);
                m = int.Parse(dimensions[2]);
                n = int.Parse(dimensions[3]);
                pondDepths = new int[m,n];

                var counter = 0;
                while((line = fileReader.ReadLine()) != null) {
                    string[] stringrow = line.Split(" ");
                    int[] rowints = Array.ConvertAll(stringrow, s => int.TryParse(s, out var i) ? i : 0).ToArray();
                    
                    for (int i = 0; i < rowints.Count(); i++) {
                        pondDepths[counter, i] = rowints[i];
                    }

                    counter++;
                }
            }
        }
    }
}