using System;
using System.Collections.Generic;

namespace seesharp {
    class ChestSizeFinder {
        private Pond pond;

        public ChestSizeFinder(Pond pond) {
            this.pond = pond;
        }

        public int findMaxVolume() {
            
            return 0;
        }

        //Find the subsequences maximizing the value of k-j * min x_i
        //k is starting point of sequence in one row and j is ending point, and x_i is the smallest x value in said sequence
        private void subsequenceFinder(int[] array, int x_i) {
            var stack = new Stack<int>();
            var candidates = new List<int>();

            for (int i = 0; i < array.Length; i++) {
                bool stackGreater = true;

                while(stackGreater)
                {
                    if(stack.Count > 0) {
                        if(stack.Peek() > array[i])
                            candidates.Add(stack.Pop() * (stack.Count - 1));
                        else
                        {
                            stack.Push(array[i]);
                            stackGreater = false;
                        }
                    }
                }
            }
        }
    }
}