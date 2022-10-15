public class ExpandArray2D
    {
        public enum Direction
        {
            down, up, left, right
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="pointerPos"></param>
        /// <param name="dir"></param>
        /// <param name="amount"></param>
        public static void ExpandArray<T>(ref T[,] arr, ref Vector2Int pointerPos, Direction dir, int amount)
        {
            T[,] tmpArr = new T[arr.GetLength(0), arr.GetLength(1)];
            Array.Copy(arr, tmpArr, arr.Length);
            switch (dir)
            {
                case Direction.down:
                    arr = new T[tmpArr.GetLength(0), tmpArr.GetLength(1) + amount];
                    for (int i = 0; i < tmpArr.GetLength(0); i++)
                    {
                        for (int j = 0; j < tmpArr.GetLength(1); j++)
                        {
                            arr[i, j + amount] = tmpArr[i, j];
                        }
                    }
                    pointerPos.y += amount;

                    break;
                case Direction.up:
                    arr = new T[tmpArr.GetLength(0), tmpArr.GetLength(1) + amount];
                    for (int i = 0; i < tmpArr.GetLength(0); i++)
                    {
                        for (int j = 0; j < tmpArr.GetLength(1); j++)
                        {
                            arr[i, j] = tmpArr[i, j];
                        }
                    }
                    break;
                case Direction.left:
                    arr = new T[tmpArr.GetLength(0) + amount, tmpArr.GetLength(1)];
                    for (int i = 0; i < tmpArr.GetLength(0); i++)
                    {
                        for (int j = 0; j < tmpArr.GetLength(1); j++)
                        {
                            arr[i + amount, j] = tmpArr[i, j];
                        }
                    }
                    pointerPos.x += amount;
                    break;
                case Direction.right:
                    arr = new T[tmpArr.GetLength(0) + amount, tmpArr.GetLength(1)];
                    for (int i = 0; i < tmpArr.GetLength(0); i++)
                    {
                        for (int j = 0; j < tmpArr.GetLength(1); j++)
                        {
                            arr[i, j] = tmpArr[i, j];
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    
    
        public static void ExpandArray<T>(ref T[,] arr, Direction dir, int amount)
        {
            T[,] tmpArr = new T[arr.GetLength(0), arr.GetLength(1)];
            Array.Copy(arr, tmpArr, arr.Length);
            switch (dir)
            {
                case Direction.down:
                    arr = new T[tmpArr.GetLength(0), tmpArr.GetLength(1) + amount];
                    for (int i = 0; i < tmpArr.GetLength(0); i++)
                    {
                        for (int j = 0; j < tmpArr.GetLength(1); j++)
                        {
                            arr[i, j + amount] = tmpArr[i, j];
                        }
                    }

                    break;
                case Direction.up:
                    arr = new T[tmpArr.GetLength(0), tmpArr.GetLength(1) + amount];
                    for (int i = 0; i < tmpArr.GetLength(0); i++)
                    {
                        for (int j = 0; j < tmpArr.GetLength(1); j++)
                        {
                            arr[i, j] = tmpArr[i, j];
                        }
                    }
                    break;
                case Direction.left:
                    arr = new T[tmpArr.GetLength(0) + amount, tmpArr.GetLength(1)];
                    for (int i = 0; i < tmpArr.GetLength(0); i++)
                    {
                        for (int j = 0; j < tmpArr.GetLength(1); j++)
                        {
                            arr[i + amount, j] = tmpArr[i, j];
                        }
                    }
                    break;
                case Direction.right:
                    arr = new T[tmpArr.GetLength(0) + amount, tmpArr.GetLength(1)];
                    for (int i = 0; i < tmpArr.GetLength(0); i++)
                    {
                        for (int j = 0; j < tmpArr.GetLength(1); j++)
                        {
                            arr[i, j] = tmpArr[i, j];
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
