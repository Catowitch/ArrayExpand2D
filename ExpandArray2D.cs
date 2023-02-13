using System;
using UnityEngine;

public class ExpandArray2D
{
    public enum Direction
    {
        down, up, left, right
    }
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T">array type</typeparam>
    /// <param name="arr">ref array</param>
    /// <param name="pointerPos">starting position</param>
    /// <param name="dir">expand direction</param>
    /// <param name="amount">expand amount</param>
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


    /// <summary>
    /// Expand array in choosen direction, and moves pointer pos with it
    /// </summary>
    /// <typeparam name="T">array type</typeparam>
    /// <param name="arr">ref array</param>
    /// <param name="pointerPos">starting position</param>
    /// <param name="dir">expand direction</param>
    /// <param name="amount">expand amount</param>
    public static void ExpandArrayJagged<T>(ref T[][] arr, ref Vector2Int pointerPos, Direction dir, int amount)
    {
        T[][] tmpArr = new T[arr.Length][];
        //for (int i = 0; i < tmpArr.Length; i++)
        //{
        //    tmpArr[i] = new T[arr[i].Length];
        //}
        Array.Copy(arr, tmpArr, arr.Length);
        switch (dir)
        {
            case Direction.down:
                arr = new T[tmpArr.Length][];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new T[tmpArr[0].Length + amount];
                }
                for (int i = 0; i < tmpArr.Length; i++)
                {
                    for (int j = 0; j < tmpArr[i].Length; j++)
                    {
                        arr[i][j + amount] = tmpArr[i][j];
                    }
                }
                pointerPos.y += amount;

                break;
            case Direction.up:
                arr = new T[tmpArr.Length][];
                for (int i = 0; i < tmpArr.Length; i++)
                {
                    arr[i] = new T[tmpArr[0].Length + amount];
                    for (int j = 0; j < tmpArr[i].Length; j++)
                    {
                        arr[i][j] = tmpArr[i][j];
                    }
                }
                break;
            case Direction.left:
                arr = new T[tmpArr.Length + amount][];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new T[tmpArr[0].Length];
                }
                for (int i = 0; i < tmpArr.Length; i++)
                {
                    for (int j = 0; j < tmpArr[i].Length; j++)
                    {
                        arr[i + amount][j] = tmpArr[i][j];
                    }
                }
                pointerPos.x += amount;
                break;
            case Direction.right:
                arr = new T[tmpArr.Length + amount][];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new T[tmpArr[0].Length];
                }
                for (int i = 0; i < tmpArr.Length; i++)
                {
                    for (int j = 0; j < tmpArr[i].Length; j++)
                    {
                        arr[i][j] = tmpArr[i][j];
                    }
                }
                break;
            default:
                break;
        }
    }


    /// <summary>
    /// Expand array in choosen direction
    /// </summary>
    /// <typeparam name="T">array type</typeparam>
    /// <param name="arr">ref array</param>
    /// <param name="dir">expand direction</param>
    /// <param name="amount">expand amount</param>
    public static void ExpandArrayJagged<T>(ref T[][] arr, Direction dir, int amount)
    {
        T[][] tmpArr = new T[arr.Length][];
        //for (int i = 0; i < tmpArr.Length; i++)
        //{
        //    tmpArr[i] = new T[arr[i].Length];
        //}
        Array.Copy(arr, tmpArr, arr.Length);
        switch (dir)
        {
            case Direction.down:
                arr = new T[tmpArr.Length][];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new T[tmpArr[0].Length + amount];
                }
                for (int i = 0; i < tmpArr.Length; i++)
                {
                    for (int j = 0; j < tmpArr[i].Length; j++)
                    {
                        arr[i][j + amount] = tmpArr[i][j];
                    }
                }

                break;
            case Direction.up:
                arr = new T[tmpArr.Length][];
                for (int i = 0; i < tmpArr.Length; i++)
                {
                    arr[i] = new T[tmpArr[0].Length + amount];
                }
                for (int i = 0; i < tmpArr.Length; i++)
                {
                    for (int j = 0; j < tmpArr[i].Length; j++)
                    {
                        arr[i][j] = tmpArr[i][j];
                    }
                }
                break;
            case Direction.left:
                arr = new T[tmpArr.Length + amount][];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new T[tmpArr[0].Length];
                }
                for (int i = 0; i < tmpArr.Length; i++)
                {
                    for (int j = 0; j < tmpArr[i].Length; j++)
                    {
                        arr[i + amount][j] = tmpArr[i][j];
                    }
                }
                break;
            case Direction.right:
                arr = new T[tmpArr.Length + amount][];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new T[tmpArr[0].Length];
                }
                for (int i = 0; i < tmpArr.Length; i++)
                {
                    for (int j = 0; j < tmpArr[i].Length; j++)
                    {
                        arr[i][j] = tmpArr[i][j];
                    }
                }
                break;
            default:
                break;
        }
    }


    /// <summary>
    /// Expand array in all directions, and moves pointer pos with it
    /// </summary>
    /// <typeparam name="T">array type</typeparam>
    /// <param name="arr">ref array</param>
    /// <param name="pointerPos">starting position</param>
    /// <param name="amount">expand amount</param>
    public static void ExpandArrayJaggedAllSides<T>(ref T[][] arr, ref Vector2Int pointerPos, int amount)
    {
        T[][] tmpArr = new T[arr.Length][];
        //for (int i = 0; i < tmpArr.Length; i++)
        //{
        //    tmpArr[i] = new T[arr[i].Length];
        //}
        Array.Copy(arr, tmpArr, arr.Length);

        arr = new T[tmpArr.Length + (amount * 2)][];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new T[tmpArr[0].Length + (amount * 2)];
        }
        for (int i = 0; i < tmpArr.Length; i++)
        {
            for (int j = 0; j < tmpArr[i].Length; j++)
            {
                arr[i + amount][j + amount] = tmpArr[i][j];
            }
        }
        pointerPos += new Vector2Int(amount, amount);
    }


    /// <summary>
    /// Expand array in all directions
    /// </summary>
    /// <typeparam name="T">array type</typeparam>
    /// <param name="arr">ref array</param>
    /// <param name="amount">expand amount</param>
    public static void ExpandArrayJaggedAllSides<T>(ref T[][] arr, int amount)
    {
        T[][] tmpArr = new T[arr.Length][];
        //for (int i = 0; i < tmpArr.Length; i++)
        //{
        //    tmpArr[i] = new T[arr[i].Length];
        //}
        Array.Copy(arr, tmpArr, arr.Length);

        arr = new T[tmpArr.Length + (amount * 2)][];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new T[tmpArr[0].Length + (amount * 2)];
        }
        for (int i = 0; i < tmpArr.Length; i++)
        {
            for (int j = 0; j < tmpArr[i].Length; j++)
            {
                arr[i + amount][j + amount] = tmpArr[i][j];
            }
        }
    }

    /// <summary>
    /// Insert one 2d jagged array into other, expand if it reach out of bounds 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="insertArr"></param>
    /// <param name="dstArr"></param>
    /// <param name="pos"></param>
    public static void InsertJaggedArray<T>(T[][] insertArr, ref T[][] dstArr, Vector2Int pos)
    {
        // if pointer pos > lenght
        if (pos.x >= dstArr.Length)
        {
            ExpandArrayJagged<T>(ref dstArr, Direction.right, pos.x - dstArr.Length + 1);
        }
        if (pos.y >= dstArr[0].Length)
        {
            ExpandArrayJagged<T>(ref dstArr, Direction.up, pos.y - dstArr[0].Length + 1);
        }
        if (pos.x < 0)
        {
            ExpandArrayJagged<T>(ref dstArr, ref pos, Direction.left, Mathf.Abs(pos.x));
        }
        if (dstArr.Length < insertArr.Length + pos.x)
        {
            ExpandArrayJagged<T>(ref dstArr, Direction.right, insertArr.Length);
        }
        if (dstArr[0].Length < insertArr[0].Length + pos.y)
        {
            ExpandArrayJagged<T>(ref dstArr, Direction.up, insertArr[0].Length);
        }

        for (int i = 0; i < insertArr.Length; i++)
        {
            for (int j = 0; j < insertArr[0].Length; j++)
            {
                dstArr[pos.x + i][pos.y + j] = insertArr[i][j];
            }
        }

    }

}
