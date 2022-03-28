using System;

namespace Chess_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Piece[,] board = getInitialBoard();
            //test games:
            {
                //string[] movesForTest = new string[] {"","1g1e", "7b7d", "3g3e", "5b5d", "4g4f", "6a2e","7h6f","2e4g","6f4g","7a6c","2g2f","8a6a","5g5e","7a7b","4h7e","6c7e","5h4h","7e5f"};//checkmate. black wins
                //string[] movesForTest = new string[] { "", "6g6f", "5b5c", "7g7e", "4a8e"};// fools mate
                //string[] movesForTest = new string[] {
                //    "","4g4e","3b3d","7h6f","7a6c","2h3f","4b4c","5g5e",
                //    "3d4e","6f4e","1b1c","3h7d","5b5c","6g6e", "6a5b", "4h6f","4a3b", "1h4h","2a4b","7g7e",
                //    "2b2d", "7d6c","7b6c","6e6d", "4b5d", "6f8f", "8a6a","7e7d","2d2e","7d6c","5b6c", "8h7h",
                //    "7a8a","8f8c","3b5b","4e3c","5d3c","5e5d","6c7d","7h7d","6b6c","5d4c","5b6b","7d7f","2e3f",
                //    "6h3e","3f2g","3h2h","3c4a","4h7h","1a1b","4c4b","1b4b","6d5c","4a5c","3e5c","4b4h","7h4h",
                //    "3a5c","2h2g","6a2a","2g1h","5c1g","7f4f","6b5b","1h1g","5b5c","4f2f"
                //}; // - Kholmov, Ratmir vs. Bronstein, David

                //string[] movesForTest = new string[] {"","4g4e","5b5c", "7h6f", "6b6d", "2h3f", "7a6c", "3h7d",
                //    "6a5b", "7d6c", "5b6c","5g5e", "6d5e", "3f5e","2b2c", "6f5d","8a6a", "6h4f", "3a2b", "4h8d",
                //    "4a5b", "8d8b", "7a8b","5e6c","8b8c","5d7e","8c7d","8g8e","7d6e","7g7f","6e6f","4f5g","6f7g","8h8g","7g7h","5h4g"}; //Edward Lasker vs.George Alan Thomas

                //string[] movesForTest = new string[] { "", "7h8f", "7a8c", "5g5e", "5b5d", "6h4f", "6a4c", "5h7h", "8a7a", "7h8h", "7a8a", "8h7h" };// checking castling boolean - cant castle!!!!

                //string[] movesForTest = new string[] { "", "5g5e", "5b5d", "7h6f", "7a6c", "6f5d", "4b4c", "5d6f", "6c5e", "4g4e", "4c4d", "6h4f", "2a3c" };

                //string[] movesForTest = new string[] { "", "5g5e", "5b5d", "7h6f", "7a6c", "6f5d", "4b4c", "5d6f", "6c5e", "4g4e", "4c4d", "6h4f", "2a3c",
                //        "5h7h", "3a7e","3g3e", "5e6c","2h3f","7e6f", "4h6f", "3c4e","6h5h","6a5b","6f4h","4e5c","3e4d","6c4d","4f2d","3b3c","3f4d","3c2d","4h2f",
                //        "5a7a","4d5b","4a5b","2f2d","1b1c","2d2f","6a4a","3h5f","1a3a","1h3h","8b8c","8g8f","5c4e","5f4e","3a3h","5h3h","4a4e","2f3g","5b5e","3g5e",
                //        "4e5e","3h3b","5e5h","7h8g"};// done

                //string[] movesForTest = new string[] {
                //"", "4g4e", "7a6c","3g3e", "7b7c", "6g6f", "4b4c", "5g5e", "5b5d", "4e4d",
                //"6c8d", "3h5f", "6a7b","2h3f","5a7a","4h4g","6b6d","5h3h","6d6e","5f6g",
                //"7b6c","4g5h","2a4b","3h2h","6c5b","7g7f","3b3d","4d3c","2b3c","3e3d",
                //"4c3d","3f1e","4a3b","5h3f","1a2a","6h8f","4b2c","1e3d","6a6b","2g2f",
                //"6e7f","8g7f","5b3d","3f3d","8d7b","4h3h","3a5c","3d3c","3b5b","3c3d",
                //"5b6c","8f7g","6b2b","2h1h","2c4b","3d4c","7b5a","4c1c","5c2f","1c6c",
                //"5a6c","1g2f","2b2f","3h3g","2f2h","1h1g","2h2e","1g1h","2e2h","1h1g",
                //"2h2e","1g1h","2e2h",};//72 moves(icluding empty) this has en passant, many castlings and a threefold rule draw

                //string[] movesForTest = new string[] { "", "5g5e", "3b3d", "4h6f", "2a3c", "2g2e", "2b2c", "5h4h", "3a2b", "1g1e", "5b5d", "6f7f", "4a6c", "7h8f",
                //    "4b4c", "2h3f", "6c8c", "6g6f", "5a3a", "2e3d","2c3d","6h5g","8c5f","4g5f","8b8d","7f7d","6b6c","7d6d","3a2a","6d5c","7b7c","5c6c","7a6c",
                //    "1e1d","2b1c","1h2h","2a1a","6f6e","5d6e","8f6e","6c5e","3f4d","3c4e","6e7c","6a8c","7c5b","8a5a","5b3c","4a2a","3c2a","4e2d","2a1c","5a4a",
                //    "2h2d","5e6g","4h4g","6g5e","4g5h","4a6a","4d3b"};//4d3b is checkmate!

                //string[] movesForTest = new string[] { "", "2h3f","2a3c", "3f2h","3c2a", "2h3f", "2a3c", "3f2h",
                //    "3c2a", "2h3f", "2a3c", "3f2h", "3c2a","2h3f","2a3c", "3f2h","3c2a", }; // threefold repetition

                //string[] movesForTest = new string[] { "",
                //    "2h3f","2a3c", "3f2h","3c2a", "2h3f", "2a3c", "3f2h", "3c2a", "2h3f", "2a3c",
                //    "3f2h", "3c2a","2h3f","2a3c", "3f2h","3c2a","2h3f","2a3c", "3f2h","3c2a",
                //    "2h3f", "2a3c", "3f2h", "3c2a", "2h3f","2a3c", "3f2h", "3c2a","2h3f","2a3c",
                //    "3f2h","3c2a","2h3f","2a3c", "3f2h","3c2a", "2h3f", "2a3c", "3f2h","3c2a",
                //    "2h3f", "2a3c", "3f2h", "3c2a","2h3f","2a3c", "3f2h","3c2a","2h3f","2a3c",
                //     };// 50 moves test 1 (disabled trheefold rule to test 

                //string[] movesForTest = new string[] { "",
                //    "2h3f","2a3c", "3f2h","3c2a", "2h3f", "2a3c", "3f2h", "3c2a", "2h3f", "2a3c",
                //    "3f2h", "3c2a","2h3f","2a3c", "3f2h","3c2a","2h3f","2a3c", "3f2h","3c2a",
                //    "2h3f", "2a3c", "3f2h", "3c2a", "2h3f","2a3c", "3f2h", "3c2a","2h3f","2a3c",
                //    "3f2h","3c2a","2h3f","2a3c", "3f2h","3c2a", "2h3f", "2a3c", "3f2h","3c2a",
                //    "2h3f", "2a3c", "3f2h", "3c2a","2h3f","2a3c", "3f2h","3c2a","2h3f","8b8d",
                //    "3f2h"
                //     };// 50 moves test 2 (disabled trheefold rule to test
            }
            string[] movesForTest = new string[] { "" };


            bool isGameOver = false;
            bool isValid;
            string winner = "DRAW";
            bool isDraw = false;
            int turn = 1;
            string[] history = new string[1];
            history[0] = getStringCopyOfBoard(board);
            bool isWhitesTurn;
            int fiftyMovesRule = 0;
            while (!isGameOver)
            {
                do
                {
                    isWhitesTurn = turn % 2 != 0;
                    printBoard(board);
                    Console.WriteLine("Please enter the position of the piece you want to move,followed by the desired destination. press ENTER.\nYour input needs to look like this '2a3a' - column, row, column, row.");
                    Console.WriteLine($"{(isWhitesTurn ? "Whites" : "Blacks")} turn");
                    board = resetPawns(board, isWhitesTurn);
                    string input;
                    if (turn < movesForTest.Length) input = movesForTest[turn];
                    else input = Console.ReadLine().Trim().ToLower();
                    isValid = isValidInput(input);
                    if (isValid)
                    {
                        int inputRow = getNumberFromInput(input[1]);
                        int inputCol = getNumberFromInput(input[0]);
                        if (!(board[inputRow, inputCol] is Piece))
                        {
                            isValid = false;
                            Console.WriteLine("you picked an invalid square");
                            continue;
                        }
                        int destinationRow = getNumberFromInput(input[3]);
                        int destinationCol = getNumberFromInput(input[2]);
                        Piece piece = board[inputRow, inputCol];
                        isValid = isThereADifference(inputRow, inputCol, destinationRow, destinationCol) && piece.isYourPieceToMove(turn);
                        if (!isValid)
                        {
                            Console.WriteLine("\n not a legal move! \n");
                            continue;
                        }
                        //no need to assign new variable?
                        if (testMove(getDeepCopyOfBoard(board),input,piece))
                        {
                            if (board[inputRow, inputCol] is Pawn || board[destinationRow, destinationCol] is Piece) fiftyMovesRule = 0;
                            else fiftyMovesRule++;
                            //can now move the isValid test here?
                        }
                        object boardAfterMove = ((IPiece)piece).move(board, input);
                        if (boardAfterMove is Piece[,]) board = (Piece[,])boardAfterMove;
                        else
                        {
                            Console.WriteLine("bad move, try again");
                            isValid = false;
                        }
                    }
                    if (isValid) turn++;
                    
                } while (!isValid);
                isWhitesTurn = turn % 2 != 0;
                history = setBoardHistory2(getStringCopyOfBoard(board), history);

                if (!isLegalMoveLeft(board, isWhitesTurn) || isThreePositionRule(history) || isCheckmate(board, isWhitesTurn) || fiftyMovesRule == 50 || isOtherDraw(board))
                {
                    isGameOver = true;
                    isDraw = !isKingInCheck(board, isWhitesTurn) || isThreePositionRule(history) || fiftyMovesRule == 50 || isOtherDraw(board);
                }
                
                if (isGameOver)
                {
                    printBoard(board);
                    if (!isDraw) winner = !isWhitesTurn ? "WHITE" : "BLACK";// cause if its whites turn and game over black won (and vice versa..)
                    break;
                }
            }
            Console.WriteLine("\n\n");
            Console.WriteLine(" ____    ______           ____        _____   __  __  ____    ____   ");
            Console.WriteLine("/\\  _`\\ /\\  _  \\  /'\\_/`\\/\\  _`\\     /\\  __`\\/\\ \\/\\ \\/\\  _`\\ /\\  _`\\");
            Console.WriteLine("\\ \\ \\L\\_\\ \\ \\L\\ \\/\\      \\ \\ \\L\\_\\   \\ \\ \\/\\ \\ \\ \\ \\ \\ \\ \\L\\_\\ \\ \\L\\ \\ ");
            Console.WriteLine(" \\ \\ \\L_L\\ \\  __ \\ \\ \\__\\ \\ \\  _\\L    \\ \\ \\ \\ \\ \\ \\ \\ \\ \\  _\\L\\ \\ ,  / ");
            Console.WriteLine("  \\ \\ \\/, \\ \\ \\/\\ \\ \\ \\_/\\ \\ \\ \\L\\ \\   \\ \\ \\_\\ \\ \\ \\_/ \\ \\ \\L\\ \\ \\ \\\\ \\  ");
            Console.WriteLine("   \\ \\____/\\ \\_\\ \\_\\ \\_\\\\ \\_\\ \\____/    \\ \\_____\\ `\\___/\\ \\____/\\ \\_\\ \\_\\");
            Console.WriteLine("    \\/___/  \\/_/\\/_/\\/_/ \\/_/\\/___/      \\/_____/`\\/__/  \\/___/  \\/_/\\/ /");
            Console.WriteLine("\n\n");
            if(!isDraw)Console.WriteLine("THE WINNER IS: " + winner + "!");
            else Console.WriteLine("IT'S A DRAW!");
        }
        static public bool testMove(Piece[,] board, string input,object piece)
        {
            return ((IPiece)piece).move(board, input) != null;
        }
        static public Piece[,] getInitialBoard()
        {
            Piece[,] board = new Piece[9,9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                if (i == 0 || j == 0 || (i>2 && i<7)) continue;
                        if (i == 1)
                        {
                            if (j == 1 || j == 8) board[i, j] = new Rook(false);
                            else if (j == 2 || j == 7) board[i, j] = new Knight(false);
                            else if (j == 3 || j == 6) board[i, j] = new Bishop(false);
                            else if (j == 4) board[i, j] = new Queen(false);
                            else if (j == 5) board[i, j] = new King(false);
                        }
                        else if(i == 2)
                        {
                            board[i, j] = new Pawn(false);
                        }
                        else if(i == 8)
                        {
                            if (j == 1 || j == 8) board[i, j] = new Rook(true);
                            else if (j == 2 || j == 7) board[i, j] = new Knight(true);
                            else if (j == 3 || j == 6) board[i, j] = new Bishop(true);
                            else if (j == 4) board[i, j] = new Queen(true);
                            else if (j == 5) board[i, j] = new King(true);
                        }
                        else if (i == 7)
                        {
                            board[i, j] = new Pawn(true);
                        }
                }
            }
            return board;
        }
        public static void printBoard(Piece[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (!(board[i, j] is Piece))
                    {
                        if (i == 0)
                        {
                            Console.Write(j + "  ");
                        }
                        else if (j == 0)
                        {
                            char letter = ' ';
                            switch (i)
                            {
                                case 0: letter = '0'; break;
                                case 1: letter = 'a'; break;
                                case 2: letter = 'b'; break;
                                case 3: letter = 'c'; break;
                                case 4: letter = 'd'; break;
                                case 5: letter = 'e'; break;
                                case 6: letter = 'f'; break;
                                case 7: letter = 'g'; break;
                                case 8: letter = 'h'; break;
                            }
                            Console.Write(letter + "  ");
                        }
                        else Console.Write("   ");// works
                        continue;
                    }
                    
                    switch (board[i, j].getRank())
                    {
                        case "pawn":
                            Console.Write($"{(board[i, j].getIsWhite() ? "WP" : "BP" )}");
                            break;
                        case "rook":
                            Console.Write($"{(board[i, j].getIsWhite() ? "WR" : "BR")}");
                            break;
                        case "bishop":
                            Console.Write($"{(board[i, j].getIsWhite() ? "WB" : "BB")}");
                            break;
                        case "knight":
                            Console.Write($"{(board[i, j].getIsWhite() ? "WN" : "BN")}");
                            break;
                        case "queen":
                            Console.Write($"{(board[i, j].getIsWhite() ? "WQ" : "BQ")}");
                            break;
                        case "king":
                            Console.Write($"{(board[i, j].getIsWhite() ? "WK" : "BK")}");
                            break;
                        default:
                            Console.Write("SHOULDNT HAPPEN ");
                            break;
                    }
                    Console.Write(" ");// space after which ever option
                }
                Console.WriteLine();
            }
        }
        public static string getStringCopyOfBoard(Piece[,] board)
        {
            string deepCopyBoard = "";
            for (int i = 1; i < board.GetLength(0); i++)
            {
                for (int j = 1; j < board.GetLength(1); j++)
                {
                    if (!(board[i, j] is Piece))
                    {
                        deepCopyBoard += "EE";
                        continue;
                    }

                    switch (board[i, j].getRank())
                    {
                        case "pawn":
                            bool isDouble = ((Pawn)board[i, j]).getIsLastMoveDouble();
                            string isDoubleStr = isDouble ? "T" : "F";
                            deepCopyBoard += $"{(board[i, j].getIsWhite() ? $"WP{isDoubleStr}" : $"BP{isDoubleStr}")}";
                            break;
                        case "rook":
                            bool isMoved = ((Rook)board[i, j]).getIsMoved();
                            string isMovedStr = isMoved ? "T" : "F";
                            deepCopyBoard += $"{(board[i, j].getIsWhite() ? $"WR{isMovedStr}" : $"BR{isMovedStr}")}";
                            break;
                        case "bishop":
                            deepCopyBoard += $"{(board[i, j].getIsWhite() ? "WB" : "BB")}";
                            break;
                        case "knight":
                            deepCopyBoard += ($"{(board[i, j].getIsWhite() ? "WN" : "BN")}");
                            break;
                        case "queen":
                            deepCopyBoard += ($"{(board[i, j].getIsWhite() ? "WQ" : "BQ")}");
                            break;
                        case "king":
                            isMoved = ((King)board[i, j]).getIsMoved();
                            isMovedStr = isMoved ? "T" : "F";
                            deepCopyBoard += ($"{(board[i, j].getIsWhite() ? $"WK{isMovedStr}" : $"BK{isMovedStr}")}");
                            break;
                        default:
                            break;
                    }
                }
            }
            return deepCopyBoard;
        }
        public static bool isValidInput(string str)
        {
            if(str.Length != 4) return false;
            return (isValidNumber(str[0]) && isValidLetter(str[1]) && isValidNumber(str[2]) && isValidLetter(str[3]));
            
        }
        public static bool isValidNumber(char num)
        {
            switch (num)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                    return true;
                default:
                    return false;
            }
        }
        public static bool isValidLetter(char letter)
        {
            switch (letter)
            {
                case 'a':
                case 'b':
                case 'c':
                case 'd':
                case 'e':
                case 'f':
                case 'g':
                case 'h':
                    return true;
                default:
                    return false;
            }
        }
        public static int getNumberFromInput(char input)
        {
            switch (input)
            {
                case '1': case 'a': return 1;
                case '2': case 'b': return 2;
                case '3': case 'c': return 3;
                case '4': case 'd': return 4;
                case '5': case 'e': return 5;
                case '6': case 'f': return 6;
                case '7': case 'g': return 7;
                case '8': case 'h': return 8;
                default:
                    return 0;
            }
        }
        public static bool isThereADifference(int row, int col, int destinationRow, int destinationCol)
        {
            return row != destinationRow || col != destinationCol;
        }
        public static string[] setBoardHistory2(string board, string[] previousHistory)
        {
            string[] history = new string[previousHistory.Length + 1];
            for (int i = 0; i < previousHistory.Length; i++)
            {
                history[i] = previousHistory[i];
            }
            history[previousHistory.Length] = board;
            return history;
        }
        public static void printBoardCopies(string[,] board)
        {
            Console.WriteLine("====================================");
            Console.WriteLine();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("====================================");
            Console.WriteLine();
        }
        public static bool isThreePositionRule(string[] history)
        {
            //check if there's a repitition of any of the boards
            int count = 0;
            for (int i = 0; i < history.Length && count<3; i++)
            {
                string board = history[i];
                for (int j = 0; j < history.Length; j++)
                {
                    if(i == j) continue;
                    string boardToCompare = history[j];
                    if (board.Equals(boardToCompare))
                    {
                        count++;
                        if (count == 2) break;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine("THREEFOLD RULE");
                    return true;
                }
                count = 0;
            }
            return false;
        }
        public static Piece[,] resetPawns(Piece[,] board, bool isWhite)
        {
            //this resets any double move there was last turn
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] is Pawn && board[i,j].getIsWhite() == isWhite) ((Pawn)board[i, j]).setIsLastMoveDouble(false);
                }
            }
            return board;
        }
        public static bool isCheckmate(Piece[,] board,bool isWhiteTurn)
        {
            //check whos turn it is
            //check the color of the checkedKing
            for (int i = 1; i < board.GetLength(0); i++)
            {
                for (int j = 1; j < board.GetLength(1); j++)
                {
                    if (!(board[i, j] is Piece)) continue;
                    if (board[i,j].getRank() == "king" && board[i, j].getIsWhite())//if this piece is a WHITE KING
                    {
                        if (isCheck(board, i, j, board[i, j].getIsWhite()))
                        {
                            Console.WriteLine("\n!!!!!!!!!!!!!!!!CHECK!!!!!!!!!!!!!!!!\n");
                            if (!isAbleToUncheck(board,i,j, board[i, j].getIsWhite())) return true;
                        }
                    }
                    if (board[i, j].getRank() == "king" && !board[i, j].getIsWhite())//if this piece is a BLACK KING
                    {
                        if (isCheck(board, i, j, board[i, j].getIsWhite()) )
                        {
                            Console.WriteLine("\n!!!!!!!!!!!!!!CHECK!!!!!!!!!!!!!!!!\n");
                            if (!isAbleToUncheck(board, i, j, board[i, j].getIsWhite())) return true; 
                        }
                    }
                }
            }
            return false;
        }
        public static bool isAbleToUncheck(Piece[,] board, int kingRow, int kingCol,bool isWhite)
        {
            King king = (King)board[kingRow,kingCol];
            bool isBlockingCheck = false;
            for (int i = 1; i < board.GetLength(0) && !isBlockingCheck; i++)
            {
                for (int j = 1; j < board.GetLength(1); j++)
                {
                    if (board[i, j] is Piece && board[i, j].getIsWhite() == isWhite)
                    {
                        isBlockingCheck = isThisPieceCanBlock(board, i, j, king,kingRow,kingCol);
                        if(isBlockingCheck) break;
                    }
                }
            }
            Console.WriteLine("is able to uncheck?: " + isBlockingCheck);
            return isBlockingCheck;
        }
        public static Piece[,] getDeepCopyOfBoard(Piece[,] board)
        {
            Piece[,] testBoard = new Piece[9, 9];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (i == 0 || j == 0) continue;
                    if (board[i, j] is Piece)
                    {
                        if (board[i, j] is Pawn) testBoard[i, j] = new Pawn(board[i, j].getIsWhite());
                        else if (board[i, j] is Knight) testBoard[i, j] = new Knight(board[i, j].getIsWhite());
                        else if (board[i, j] is Bishop) testBoard[i, j] = new Bishop(board[i, j].getIsWhite());
                        else if (board[i, j] is Queen) testBoard[i, j] = new Queen(board[i, j].getIsWhite());
                        else if (board[i, j] is King) testBoard[i, j] = new King(board[i, j].getIsWhite(), ((King)board[i, j]).getIsMoved());
                        else if (board[i, j] is Rook) testBoard[i, j] = new Rook(board[i, j].getIsWhite(), ((Rook)board[i, j]).getIsMoved());
                    }
                }
            }
            return testBoard;
        }
        public static string getLetterFromNumber(int num)
        {
            switch (num)
            {
                case 1: return "a";
                case 2: return "b";
                case 3: return "c";
                case 4: return "d";
                case 5: return "e";
                case 6: return "f";
                case 7: return "g";
                case 8: return "h";
                default: return "Z";
            }
        }
        public static bool isThisPieceCanBlock(Piece[,] board,int row,int col, King king,int kingRow,int kingCol)
        {
            Piece[,] testBoard = getDeepCopyOfBoard(board);

             if(testBoard[row,col] is Pawn)
             {
                if (king.getIsWhite()) //white
                {
                    string playerMove;
                    if (row - 2 > 0)
                    {
                        playerMove = "" + col + getLetterFromNumber(row) + (col) + getLetterFromNumber(row - 2);
                        testBoard = ((Pawn)testBoard[row, col]).move(testBoard, playerMove);
                        if (!(testBoard is null) && !isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                    if(row - 1 > 0)
                    {
                        playerMove = "" + col + getLetterFromNumber(row) + (col) + getLetterFromNumber(row - 1);
                        testBoard = ((Pawn)testBoard[row, col]).move(testBoard, playerMove);
                        if (!(testBoard is null) && !isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }

                    if (row - 1 > 0 && col + 1 < 9 && testBoard[row - 1, col + 1] is Piece) 
                    {
                        playerMove = "" + col + getLetterFromNumber(row) + (col + 1) + getLetterFromNumber(row - 1);
                        testBoard = ((Pawn)testBoard[row, col]).move(testBoard, playerMove);
                        if (!(testBoard is null) && !isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                    if (row - 1 > 0 && col - 1 > 0 && testBoard[row - 1, col - 1] is Piece) 
                    {
                        playerMove = "" + col + getLetterFromNumber(row) + (col - 1) + getLetterFromNumber(row - 1);
                        testBoard = ((Pawn)testBoard[row, col]).move(testBoard, playerMove);
                        if (!(testBoard is null) && !isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                    }
                }
                else//black
                {
                    testBoard = getDeepCopyOfBoard(board);
                    string playerMove;
                    if(row + 2 < 9)
                    {
                    playerMove = "" + col + getLetterFromNumber(row) + (col) + getLetterFromNumber(row + 2);
                    testBoard = ((Pawn)testBoard[row, col]).move(testBoard, playerMove);
                    if (!(testBoard is null) && !isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                    testBoard = getDeepCopyOfBoard(board);
                    }
                    if(row + 1 < 9)
                    {
                    playerMove = "" + col + getLetterFromNumber(row) + (col) + getLetterFromNumber(row + 1);
                    testBoard = ((Pawn)testBoard[row, col]).move(testBoard, playerMove);
                    if (!(testBoard is null) && !isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                    testBoard = getDeepCopyOfBoard(board);
                    }
                    if (row + 1 < 9 && col + 1 < 9 && testBoard[row + 1, col + 1] is Piece) 
                    {
                        playerMove = "" + col + getLetterFromNumber(row) + (col + 1) + getLetterFromNumber(row + 1);
                        testBoard = ((Pawn)testBoard[row, col]).move(testBoard, playerMove);
                        if (!(testBoard is null) && !isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                    if (row + 1 < 9 && col - 1 > 0 && testBoard[row + 1, col - 1] is Piece)
                    {
                        playerMove = "" + col + getLetterFromNumber(row) + (col - 1) + getLetterFromNumber(row + 1);
                        testBoard = ((Pawn)testBoard[row, col]).move(testBoard, playerMove);
                        if (!(testBoard is null) && !isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                    }
                }
             }
             else if(testBoard[row, col] is Queen)
             {
                //diagonal right down, directly down,directly right
                for (int i = row; i < testBoard.GetLength(0); i++)
                {
                    for (int j = col; j < testBoard.GetLength(0); j++)  
                    {
                        string playerMove = "" + col + getLetterFromNumber(row) + (j) + getLetterFromNumber(i);
                        testBoard = ((Queen)testBoard[row, col]).move(testBoard, playerMove);
                        if(testBoard is null)
                        {
                            testBoard = getDeepCopyOfBoard(board);
                            continue;
                        }
                        if (!isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                }
                //diagonal left up,directly up,directly left
                for (int i = row; i >0; i--)
                {
                    for (int j = col; j >0; j--)
                    {
                        string playerMove = "" + col + getLetterFromNumber(row) + (j) + getLetterFromNumber(i);
                        testBoard = ((Queen)testBoard[row, col]).move(testBoard, playerMove);
                        if (testBoard is null)
                        {
                            testBoard = getDeepCopyOfBoard(board);
                            continue;
                        }
                        if (!isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                }
                //diagonal right down
                for (int i = row; i < testBoard.GetLength(0); i++)
                {
                    for (int j = col; j >0; j--)
                    {
                        string playerMove = "" + col + getLetterFromNumber(row) + (j) + getLetterFromNumber(i);
                        testBoard = ((Queen)testBoard[row, col]).move(testBoard, playerMove);
                        if (testBoard is null)
                        {
                            testBoard = getDeepCopyOfBoard(board);
                            continue;
                        }
                        if (!isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                }
                //diagonal right up
                for (int i = row; i > 0; i--)
                {
                    for (int j = col; j < 9; j++)
                    {
                        /*if (i != j) continue;*/// this makes sure only diagonal and one file or one row
                        string playerMove = "" + col + getLetterFromNumber(row) + (j) + getLetterFromNumber(i);
                        //Console.WriteLine("(QUEEN) the string i send to check checkmate: " + playerMove);
                        testBoard = ((Queen)testBoard[row, col]).move(testBoard, playerMove);
                        if (testBoard is null)
                        {
                            testBoard = getDeepCopyOfBoard(board);
                            continue;
                        }
                        if (!isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                }
             }
             else if (testBoard[row, col] is King)
             {
                //down
                string playerMove = "" + col + getLetterFromNumber(row) + (col) + getLetterFromNumber(row + 1);
                Console.WriteLine(testBoard[row, col].getRank());
                testBoard = ((King)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null) && !isCheck(testBoard, row + 1, col, king.getIsWhite())) return true;
                testBoard = getDeepCopyOfBoard(board);
                //up
                playerMove = "" + col + getLetterFromNumber(row) + (col) + getLetterFromNumber(row - 1);
                testBoard = ((King)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null) && !isCheck(testBoard, row-1, col, king.getIsWhite())) return true;
                testBoard = getDeepCopyOfBoard(board);
                //right
                playerMove = "" + col + getLetterFromNumber(row) + (col + 1) + getLetterFromNumber(row);
                testBoard = ((King)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null) && !isCheck(testBoard, row, col+1, king.getIsWhite())) return true;
                testBoard = getDeepCopyOfBoard(board);
                //left
                playerMove = "" + col + getLetterFromNumber(row) + (col-1) + getLetterFromNumber(row);
                testBoard = ((King)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null) && !(isCheck(testBoard, row, col - 1, king.getIsWhite()))) return true;
                testBoard = getDeepCopyOfBoard(board);
                //little castling
                playerMove = "" + col + getLetterFromNumber(row) + (col + 2) + getLetterFromNumber(row);
                testBoard = ((King)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null) && !isCheck(testBoard, row, col + 2, king.getIsWhite())) return true;
                testBoard = getDeepCopyOfBoard(board);
                //big castling
                playerMove = "" + col + getLetterFromNumber(row) + (col - 2) + getLetterFromNumber(row);
                testBoard = ((King)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null) && !(isCheck(testBoard, row, col - 2, king.getIsWhite()))) return true;
                testBoard = getDeepCopyOfBoard(board);
                //right down
                playerMove = "" + col + getLetterFromNumber(row) + (col+1) + getLetterFromNumber(row + 1);
                testBoard = ((King)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null) && !isCheck(testBoard, row+1, col+1, king.getIsWhite())) return true;
                testBoard = getDeepCopyOfBoard(board);
                //right up
                playerMove = "" + col + getLetterFromNumber(row) + (col+1) + getLetterFromNumber(row - 1);
                testBoard = ((King)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null) && !isCheck(testBoard, row-1, col+1, king.getIsWhite())) return true;
                testBoard = getDeepCopyOfBoard(board);
                //left down
                playerMove = "" + col + getLetterFromNumber(row) + (col-1) + getLetterFromNumber(row + 1);
                testBoard = ((King)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null) && !isCheck(testBoard, row+1, col-1, king.getIsWhite())) return true;
                testBoard = getDeepCopyOfBoard(board);
                //left up
                playerMove = "" + col + getLetterFromNumber(row) + (col-1) + getLetterFromNumber(row - 1);
                testBoard = ((King)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null) && !isCheck(testBoard, row-1, col-1, king.getIsWhite())) return true;
            }
             else if (testBoard[row, col] is Bishop)
             {
                //diagonal right down
                for (int i = row; i < testBoard.GetLength(0); i++)
                {
                    for (int j = col; j < testBoard.GetLength(0); j++)
                    {
                        string playerMove = "" + col + getLetterFromNumber(row) + (j) + getLetterFromNumber(i);
                        testBoard = ((Bishop)testBoard[row, col]).move(testBoard, playerMove);
                        if (testBoard is null)
                        {
                            testBoard = getDeepCopyOfBoard(board);
                            continue;
                        }
                        if (!isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                }
                //diagonal left up
                for (int i = row; i > 0; i--)
                {
                    for (int j = col; j > 0; j--)
                    {
                        string playerMove = "" + col + getLetterFromNumber(row) + (j) + getLetterFromNumber(i);
                        testBoard = ((Bishop)testBoard[row, col]).move(testBoard, playerMove);
                        if (testBoard is null)
                        {
                            testBoard = getDeepCopyOfBoard(board);
                            continue;
                        }
                        if (!isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                }
                //diagonal right down
                for (int i = row; i < testBoard.GetLength(0); i++)
                {
                    for (int j = col; j > 0; j--)
                    {
                        string playerMove = "" + col + getLetterFromNumber(row) + (j) + getLetterFromNumber(i);
                        testBoard = ((Bishop)testBoard[row, col]).move(testBoard, playerMove);
                        if (testBoard is null)
                        {
                            testBoard = getDeepCopyOfBoard(board);
                            continue;
                        }
                        if (!isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                }
                //diagonal right up
                for (int i = row; i > 0; i--)
                {
                    for (int j = col; j < 9; j++)
                    {
                        string playerMove = "" + col + getLetterFromNumber(row) + (j) + getLetterFromNumber(i);
                        testBoard = ((Bishop)testBoard[row, col]).move(testBoard, playerMove);
                        if (testBoard is null)
                        {
                            testBoard = getDeepCopyOfBoard(board);
                            continue;
                        }
                        if (!isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                }
            }
             else if (testBoard[row, col] is Rook)
             {
                int rowDiff = 9 - row;
                for (int i = 1; i < rowDiff && row + i <9; i++)
                {
                //down
                string playerMove = "" + col + getLetterFromNumber(row) + (col) + getLetterFromNumber(row + i);
                testBoard = ((Rook)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null) && !isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                testBoard = getDeepCopyOfBoard(board);
                }

                //up
                for (int i = 1; i < rowDiff && row - i > 0; i++)
                {
                    string playerMove = "" + col + getLetterFromNumber(row) + (col) + getLetterFromNumber(row - i);
                    testBoard = ((Rook)testBoard[row, col]).move(testBoard, playerMove);
                    if (!(testBoard is null) && !isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                    testBoard = getDeepCopyOfBoard(board);
                }
                //right
                for (int i = 1; i < rowDiff && col +i < 9; i++)
                {
                    string playerMove = "" + col + getLetterFromNumber(row) + (col + i) + getLetterFromNumber(row);
                    testBoard = ((Rook)testBoard[row, col]).move(testBoard, playerMove);
                    if (!(testBoard is null) && !isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                    testBoard = getDeepCopyOfBoard(board);
                }
                //left
                for (int i = 1; i < rowDiff && col - i > 0; i++)
                {
                    string playerMove = "" + col + getLetterFromNumber(row) + (col - i) + getLetterFromNumber(row);
                    testBoard = ((Rook)testBoard[row, col]).move(testBoard, playerMove);
                    if (!(testBoard is null) && !isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                    testBoard = getDeepCopyOfBoard(board);
                }
            }
            else if (testBoard[row, col] is Knight)
             {
                //1
                string playerMove = "" + col + getLetterFromNumber(row) + (col+2) + getLetterFromNumber(row + 1);
                testBoard = ((Knight)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null) && !isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                testBoard = getDeepCopyOfBoard(board);
                //2
                 playerMove = "" + col + getLetterFromNumber(row) + (col + 1) + getLetterFromNumber(row + 2);
                testBoard = ((Knight)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null) && !isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                testBoard = getDeepCopyOfBoard(board);
                //3
                playerMove = "" + col + getLetterFromNumber(row) + (col - 2) + getLetterFromNumber(row - 1);
                testBoard = ((Knight)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null) && !isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                testBoard = getDeepCopyOfBoard(board);
                //4
                playerMove = "" + col + getLetterFromNumber(row) + (col - 1) + getLetterFromNumber(row - 2);
                testBoard = ((Knight)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null) && !isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                testBoard = getDeepCopyOfBoard(board);
                //5
                playerMove = "" + col + getLetterFromNumber(row) + (col - 2) + getLetterFromNumber(row + 1);
                testBoard = ((Knight)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null) && !isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                testBoard = getDeepCopyOfBoard(board);
                //6
                playerMove = "" + col + getLetterFromNumber(row) + (col + 2) + getLetterFromNumber(row - 1);
                testBoard = ((Knight)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null) && !isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                testBoard = getDeepCopyOfBoard(board);
                //7
                playerMove = "" + col + getLetterFromNumber(row) + (col - 1) + getLetterFromNumber(row + 2);
                testBoard = ((Knight)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null) && !isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
                testBoard = getDeepCopyOfBoard(board);
                //8
                playerMove = "" + col + getLetterFromNumber(row) + (col + 1) + getLetterFromNumber(row - 2);
                testBoard = ((Knight)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null) && !isCheck(testBoard, kingRow, kingCol, king.getIsWhite())) return true;
            }
            return false;
        }
        public static bool isCheck(Piece[,] board,int row,int col,bool isWhite)
        {
            //diagonal up left i- j-
            int diff = 1;
            //Console.WriteLine("CHECK TEST =====1=====");
            while (diff < 7 && col - diff > 0 && row - diff > 0)
            {
                int newRow = row - diff;
                int newCol = col - diff;
                if (board[newRow, newCol] is null)
                {
                    diff++;
                    continue;
                }
                if (board[newRow, newCol] is Piece && board[newRow, newCol].getIsWhite() == isWhite) break;
                else if (diff == 1 && (board[newRow, newCol] is King || (board[newRow, newCol] is Pawn && board[newRow, newCol].getIsWhite() == false))) return true;
                else if (board[newRow, newCol] is Queen || board[newRow, newCol] is Bishop) return true;
                else if (board[newRow, newCol] is Piece) break;
                diff++;
            }
            //diagonal up right i-,j+
            //Console.WriteLine("CHECK TEST =====2=====");
            diff = 1;
            while(diff<7 && col + diff < 9 && row - diff>0)
            {
                int newRow = row - diff;
                int newCol = col + diff;
                if (board[newRow, newCol] is null)
                {
                    diff++;
                    continue;
                }
                if (board[newRow, newCol] is Piece && board[newRow, newCol].getIsWhite() == isWhite) break;
                else if (diff == 1 && (board[newRow, newCol] is King || (board[newRow, newCol] is Pawn && board[newRow, newCol].getIsWhite() == false))) return true;//either King or black Pawn
                else if (board[newRow, newCol] is Queen || board[newRow, newCol] is Bishop) return true;
                else if (board[newRow, newCol] is Piece) break;
                diff++;
            }
            diff = 1;
            //diagonal down left i+,j-
            //Console.WriteLine("CHECK TEST =====3=====");
            while (diff < 7 && col - diff > 0 && row + diff <9)
            {
                int newRow = row + diff;
                int newCol = col - diff;
                if (board[newRow, newCol] is null)
                {
                    diff++;
                    continue;
                }
                if (board[newRow, newCol] is Piece && board[newRow, newCol].getIsWhite() == isWhite) break;
                else if (diff == 1 && (board[newRow, newCol] is King || (board[newRow, newCol] is Pawn && board[newRow, newCol].getIsWhite() == true))) return true;
                else if (board[newRow, newCol] is Queen || board[newRow, newCol] is Bishop) return true;
                else if (board[newRow, newCol] is Piece) break;
                diff++;
            }
            //diagonal down right i+, j+
            diff = 1;
            //Console.WriteLine("CHECK TEST =====4=====");
            while (diff < 7 && col + diff < 9 && row + diff < 9)
            {
                int newRow = row + diff;
                int newCol = col + diff;
                if (board[newRow, newCol] is null)
                {
                    diff++;
                    continue;
                }
                if (board[newRow, newCol] is Piece && board[newRow, newCol].getIsWhite() == isWhite) break;
                else if (diff == 1 && (board[newRow, newCol] is King || (board[newRow, newCol] is Pawn && board[newRow, newCol].getIsWhite() == true))) return true;
                else if (board[newRow, newCol] is Queen || board[newRow, newCol] is Bishop) return true;
                else if (board[newRow, newCol] is Piece) break;
                diff++;
            }
            //straight up i-,j==col
            //Console.WriteLine("CHECK TEST =====5=====");
            for (int i = row - 1 < 1? 1: row-1; i > 0; i--)
            {
                //if (board[i, col] is not object) break;
                if (board[i, col] is null) continue;
                Piece currPiece = board[i, col];
                if (currPiece.getIsWhite() == isWhite) break;
                if (i == row - 1 && currPiece is King) return true;
                else if (currPiece is Rook || currPiece is Queen) return true;
                else if (currPiece is Piece) break;
            }
            //straight down i+ j==col
            //Console.WriteLine("CHECK TEST =====6=====");
            for (int i = row + 1 >8? 8 : row+1; i < 9; i++)
            {
                if (board[i, col] is null) continue;
                if (board[i, col] is not null && board[i, col] is not Piece) break;
                Piece currPiece = board[i, col];
                if (currPiece.getIsWhite() == isWhite) break;
                if (i == 2 && currPiece is King) return true;
                else if (currPiece is Rook || currPiece is Queen) return true;
                else if (currPiece is Piece) break;
            }
            //right i==row,j+
            //Console.WriteLine("CHECK TEST =====7=====");
            for (int i = col + 1 > 8? 8 : col+1; i < 9; i++)
            {
                //if (board[row, i] is not object) break;
                if (board[row, i] is null) continue;
                Piece currPiece = board[row, i];
                if (currPiece.getIsWhite() == isWhite) break;

                if (i == col + 1 && currPiece is King) return true;
                else if (currPiece is Rook || currPiece is Queen) return true;
                else if (currPiece is Piece) break;
            }
            //left i==row,j-
            //Console.WriteLine("CHECK TEST =====8=====");
            for (int i = col - 1<0? 1: col-1; i > 0; i--)
            {
                //if (board[row, i] is not object) break;
                if (board[row, i] is null) continue;
                Piece currPiece = board[row, i];
                if (currPiece.getIsWhite() == isWhite) break;

                if (i == col - 1 && currPiece is King) return true;
                else if (currPiece is Rook || currPiece is Queen) return true;
                else if (currPiece is Piece) break;
            }
            //Console.WriteLine("CHECK TEST =====9=====");
            //knights:
            if (
                (row + 2 < 9) && (col + 1 < 9) && board[row + 2, col + 1] is Knight && (board[row + 2, col + 1].getIsWhite() != isWhite)
                ||
                (row - 2 > 0) && (col + 1 < 9) && board[row - 2, col + 1] is Knight && (board[row - 2, col + 1].getIsWhite() != isWhite)
                ||
                (row - 2 > 0) && (col - 1 > 0) && board[row - 2, col - 1] is Knight && (board[row - 2, col - 1].getIsWhite() != isWhite)
                ||
                (row + 2 < 9) && (col - 1 > 0) && board[row + 2, col - 1] is Knight && (board[row + 2, col - 1].getIsWhite() != isWhite)
                ||
                (row + 1 < 9) && (col - 2 > 0) && board[row + 1, col - 2] is Knight && (board[row + 1, col - 2].getIsWhite() != isWhite)
                ||
                (row - 1 > 0) && (col - 2 > 0) && board[row - 1, col - 2] is Knight && (board[row - 1, col - 2].getIsWhite() != isWhite)
                ||
                (row + 1 < 9) && (col + 2 < 9) && board[row + 1, col + 2] is Knight && (board[row + 1, col + 2].getIsWhite() != isWhite)
                ||
                (row - 1 > 0) && (col + 2 < 9) && board[row - 1, col + 2] is Knight && (board[row - 1, col + 2].getIsWhite() != isWhite)
                )
            {
                return true;
            }
            //Console.WriteLine("CHECK TEST =====NONE=====");
            return false;
        }
        public static bool isKingInCheck(Piece[,] board, bool isWhite)
        {
            bool isKingInCheck = false;
            for (int i = 0; i < board.GetLength(0) && !isKingInCheck; i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if(board[i,j] is Piece && board[i,j] is King && board[i,j].getIsWhite() == isWhite)
                    {
                        if (isCheck(board, i, j, isWhite)) isKingInCheck = true ;
                    }
                }
            }
            return isKingInCheck;
        }
        public static bool isLegalMoveLeft(Piece[,] board, bool isWhite)
        {
            bool isAbleToMove = false;
            for (int i = 1; i < board.GetLength(0) && !isAbleToMove; i++)
            {
                for (int j = 1; j < board.GetLength(1); j++)
                {
                    if (board[i, j] is Piece && board[i, j].getIsWhite() == isWhite)
                    {
                        if(isThisPieceCanMove(board, i, j))
                        {
                            isAbleToMove = true ;
                            break;
                        }
                    }
                }
            }
            if (!isAbleToMove) Console.WriteLine("CANT DO ANY LEGAL MOVE");
            return isAbleToMove;
        }
        public static bool isThisPieceCanMove(Piece[,] board,int row,int col)
        {
            Piece[,] testBoard = getDeepCopyOfBoard(board);

            if (testBoard[row, col] is Pawn)
            {
                if (testBoard[row,col].getIsWhite())//white
                {
                    string playerMove;
                    if (row - 2 > 0)
                    {
                    playerMove = "" + col + getLetterFromNumber(row) + (col) + getLetterFromNumber(row - 2);
                    testBoard = ((Pawn)testBoard[row, col]).move(testBoard, playerMove);
                    if (!(testBoard is null)) return true;
                    testBoard = getDeepCopyOfBoard(board);
                    }
                    if(row - 1 > 0)
                    {
                    playerMove = "" + col + getLetterFromNumber(row) + (col) + getLetterFromNumber(row - 1);
                    testBoard = ((Pawn)testBoard[row, col]).move(testBoard, playerMove);
                    if (!(testBoard is null)) return true;
                    testBoard = getDeepCopyOfBoard(board);
                    }
                    if (row - 1 > 0 && col - 1 > 0 && testBoard[row - 1, col - 1] is Piece)
                    {
                        playerMove = "" + col + getLetterFromNumber(row) + (col - 1) + getLetterFromNumber(row - 1);
                        testBoard = ((Pawn)testBoard[row, col]).move(testBoard, playerMove);
                        if (!(testBoard is null)) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                    if (row - 1 > 0 && col + 1 < 9 && testBoard[row - 1, col + 1] is Piece)
                    {
                        playerMove = "" + col + getLetterFromNumber(row) + (col + 1) + getLetterFromNumber(row - 1);
                        testBoard = ((Pawn)testBoard[row, col]).move(testBoard, playerMove);
                        if (!(testBoard is null)) return true;
                    }
                    
                    
                }
                else//black
                {
                    string playerMove;
                    if(row + 2 < 9)
                    {
                        playerMove = "" + col + getLetterFromNumber(row) + (col) + getLetterFromNumber(row +2);
                        testBoard = ((Pawn)testBoard[row, col]).move(testBoard, playerMove);
                        if (!(testBoard is null)) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                    if (row + 1 < 9)
                    {
                        playerMove = "" + col + getLetterFromNumber(row) + (col) + getLetterFromNumber(row + 1);
                        testBoard = ((Pawn)testBoard[row, col]).move(testBoard, playerMove);
                        if (!(testBoard is null)) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                    if (row + 1 < 9 && col - 1 > 0 && testBoard[row + 1, col - 1] is Piece)
                    {
                        playerMove = "" + col + getLetterFromNumber(row) + (col - 1) + getLetterFromNumber(row + 1);
                        testBoard = ((Pawn)testBoard[row, col]).move(testBoard, playerMove);
                        if (!(testBoard is null)) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                    if (row + 1 < 9 && col + 1 < 9 && testBoard[row + 1, col + 1] is Piece)
                    {
                        playerMove = "" + col + getLetterFromNumber(row) + (col + 1) + getLetterFromNumber(row + 1);
                        testBoard = ((Pawn)testBoard[row, col]).move(testBoard, playerMove);
                        if (!(testBoard is null)) return true;
                    }
                }
            }
            else if (testBoard[row, col] is Queen)
            {
                //diagonal right down, directly down,directly right
                for (int i = row; i < testBoard.GetLength(0); i++)
                {
                    for (int j = col; j < testBoard.GetLength(0); j++)
                    {
                        string playerMove = "" + col + getLetterFromNumber(row) + (j) + getLetterFromNumber(i);
                        testBoard = ((Queen)testBoard[row, col]).move(testBoard, playerMove);
                        if (!(testBoard is null)) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                }
                //diagonal left up,directly up,directly left
                for (int i = row; i > 0; i--)
                {
                    for (int j = col; j > 0; j--)
                    {
                        string playerMove = "" + col + getLetterFromNumber(row) + (j) + getLetterFromNumber(i);
                        testBoard = ((Queen)testBoard[row, col]).move(testBoard, playerMove);
                        if (!(testBoard is null)) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                }
                //diagonal right down
                for (int i = row; i < testBoard.GetLength(0); i++)
                {
                    for (int j = col; j > 0; j--)
                    {
                        string playerMove = "" + col + getLetterFromNumber(row) + (j) + getLetterFromNumber(i);
                        testBoard = ((Queen)testBoard[row, col]).move(testBoard, playerMove);
                        if (!(testBoard is null)) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                }
                //diagonal right up
                for (int i = row; i > 0; i--)
                {
                    for (int j = col; j < 9; j++)
                    {
                        string playerMove = "" + col + getLetterFromNumber(row) + (j) + getLetterFromNumber(i);
                        testBoard = ((Queen)testBoard[row, col]).move(testBoard, playerMove);
                        if (!(testBoard is null)) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                }
            }
            else if (testBoard[row, col] is King)
            {
                //down
                string playerMove = "" + col + getLetterFromNumber(row) + (col) + getLetterFromNumber(row + 1);
                testBoard = ((King)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null)) return true;
                testBoard = getDeepCopyOfBoard(board);
                //up
                playerMove = "" + col + getLetterFromNumber(row) + (col) + getLetterFromNumber(row - 1);
                testBoard = ((King)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null)) return true;
                testBoard = getDeepCopyOfBoard(board);
                //right
                playerMove = "" + col + getLetterFromNumber(row) + (col + 1) + getLetterFromNumber(row);
                testBoard = ((King)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null)) return true;
                testBoard = getDeepCopyOfBoard(board);
                //left
                playerMove = "" + col + getLetterFromNumber(row) + (col - 1) + getLetterFromNumber(row);
                testBoard = ((King)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null)) return true;
                testBoard = getDeepCopyOfBoard(board);
                //right down
                playerMove = "" + col + getLetterFromNumber(row) + (col + 1) + getLetterFromNumber(row + 1);
                testBoard = ((King)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null)) return true;
                testBoard = getDeepCopyOfBoard(board);
                //right up
                playerMove = "" + col + getLetterFromNumber(row) + (col + 1) + getLetterFromNumber(row - 1);
                testBoard = ((King)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null)) return true;
                testBoard = getDeepCopyOfBoard(board);
                //left down
                playerMove = "" + col + getLetterFromNumber(row) + (col - 1) + getLetterFromNumber(row + 1);
                testBoard = ((King)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null)) return true;
                testBoard = getDeepCopyOfBoard(board);
                //left up
                playerMove = "" + col + getLetterFromNumber(row) + (col - 1) + getLetterFromNumber(row - 1);
                testBoard = ((King)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null)) return true;
            }
            else if (testBoard[row, col] is Bishop)
            {
                //diagonal right down
                for (int i = row; i < testBoard.GetLength(0); i++)
                {
                    for (int j = col; j < testBoard.GetLength(0); j++)
                    {
                        string playerMove = "" + col + getLetterFromNumber(row) + (j) + getLetterFromNumber(i);
                        testBoard = ((Bishop)testBoard[row, col]).move(testBoard, playerMove);
                        if (!(testBoard is null)) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                }
                //diagonal left up
                for (int i = row; i > 0; i--)
                {
                    for (int j = col; j > 0; j--)
                    {
                        string playerMove = "" + col + getLetterFromNumber(row) + (j) + getLetterFromNumber(i);
                        testBoard = ((Bishop)testBoard[row, col]).move(testBoard, playerMove);
                        if (!(testBoard is null)) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                }
                //diagonal right down
                for (int i = row; i < testBoard.GetLength(0); i++)
                {
                    for (int j = col; j > 0; j--)
                    {
                        string playerMove = "" + col + getLetterFromNumber(row) + (j) + getLetterFromNumber(i);
                        testBoard = ((Bishop)testBoard[row, col]).move(testBoard, playerMove);
                        if (!(testBoard is null)) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                }
                //diagonal right up
                for (int i = row; i > 0; i--)
                {
                    for (int j = col; j < 9; j++)
                    {
                        string playerMove = "" + col + getLetterFromNumber(row) + (j) + getLetterFromNumber(i);
                        testBoard = ((Bishop)testBoard[row, col]).move(testBoard, playerMove);
                        if (!(testBoard is null)) return true;
                        testBoard = getDeepCopyOfBoard(board);
                    }
                }
            }
            else if (testBoard[row, col] is Rook)
            {
                int rowDiff = 9 - row;
                int colDiff = 9 - col;
                for (int i = 1; i < rowDiff && row + i < 9; i++)
                {
                    //down
                    string playerMove = "" + col + getLetterFromNumber(row) + (col) + getLetterFromNumber(row + i);
                    testBoard = ((Rook)testBoard[row, col]).move(testBoard, playerMove);
                    if (!(testBoard is null)) return true;
                    testBoard = getDeepCopyOfBoard(board);
                }
                //up
                for (int i = 1; i < rowDiff && row - i > 0; i++)
                {
                    string playerMove = "" + col + getLetterFromNumber(row) + (col) + getLetterFromNumber(row - i);
                    testBoard = ((Rook)testBoard[row, col]).move(testBoard, playerMove);
                    if (!(testBoard is null)) return true;
                    testBoard = getDeepCopyOfBoard(board);
                }
                //right
                for (int i = 1; i < colDiff && col + i < 9; i++)
                {
                    string playerMove = "" + col + getLetterFromNumber(row) + (col + i) + getLetterFromNumber(row);
                    testBoard = ((Rook)testBoard[row, col]).move(testBoard, playerMove);
                    if (!(testBoard is null)) return true;
                    testBoard = getDeepCopyOfBoard(board);
                }
                //left
                for (int i = 1; i < colDiff && col - i > 0; i++)
                {
                    string playerMove = "" + col + getLetterFromNumber(row) + (col-i) + getLetterFromNumber(row);
                    testBoard = ((Rook)testBoard[row, col]).move(testBoard, playerMove);
                    if (!(testBoard is null)) return true;
                    testBoard = getDeepCopyOfBoard(board);
                }
            }
            else if (testBoard[row, col] is Knight)
            {
                string playerMove = "" + col + getLetterFromNumber(row) + (col + 2) + getLetterFromNumber(row + 1);
                testBoard = ((Knight)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null)) return true;
                testBoard = getDeepCopyOfBoard(board);
                //2
                playerMove = "" + col + getLetterFromNumber(row) + (col + 1) + getLetterFromNumber(row + 2);
                testBoard = ((Knight)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null)) return true;
                testBoard = getDeepCopyOfBoard(board);
                //3
                playerMove = "" + col + getLetterFromNumber(row) + (col - 2) + getLetterFromNumber(row - 1);
                testBoard = ((Knight)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null)) return true;
                testBoard = getDeepCopyOfBoard(board);
                //4
                playerMove = "" + col + getLetterFromNumber(row) + (col - 1) + getLetterFromNumber(row - 2);
                testBoard = ((Knight)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null)) return true;
                testBoard = getDeepCopyOfBoard(board);
                //5
                playerMove = "" + col + getLetterFromNumber(row) + (col - 2) + getLetterFromNumber(row + 1);
                testBoard = ((Knight)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null)) return true;
                testBoard = getDeepCopyOfBoard(board);
                //6
                playerMove = "" + col + getLetterFromNumber(row) + (col + 2) + getLetterFromNumber(row - 1);
                testBoard = ((Knight)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null)) return true;
                testBoard = getDeepCopyOfBoard(board);
                //7
                playerMove = "" + col + getLetterFromNumber(row) + (col -1) + getLetterFromNumber(row + 2);
                testBoard = ((Knight)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null)) return true;
                testBoard = getDeepCopyOfBoard(board);
                //8
                playerMove = "" + col + getLetterFromNumber(row) + (col + 1) + getLetterFromNumber(row - 2);
                testBoard = ((Knight)testBoard[row, col]).move(testBoard, playerMove);
                if (!(testBoard is null)) return true;
            }
            return false;
        }
        public static bool isOtherDraw(Piece[,] board)
        {
            int whiteKingCount = 0; 
            int whiteQueenCount = 0;
            int whitePawnCount = 0;
            int whiteRookCount = 0;
            int whiteKnightCount = 0;
            int whiteBishopCount = 0;
            int blackKingCount = 0;
            int blackQueenCount = 0; 
            int blackPawnCount = 0; 
            int blackRookCount = 0; 
            int blackKnightCount = 0; 
            int blackBishopCount = 0;
            bool isWhiteBishopOnWhiteCell = false;
            bool isBlackBishopOnWhiteCell = false;
            int squareCount = 0;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    squareCount++;
                    if (board[i, j] is King && board[i, j].getIsWhite()) whiteKingCount++; 
                    if (board[i, j] is King && !board[i, j].getIsWhite()) blackKingCount++;

                    if (board[i, j] is Queen && board[i, j].getIsWhite()) whiteQueenCount++;
                    if (board[i, j] is Queen && !board[i, j].getIsWhite()) blackQueenCount++;

                    if (board[i, j] is Pawn && board[i, j].getIsWhite()) whitePawnCount++;
                    if (board[i, j] is Pawn && !board[i, j].getIsWhite()) blackPawnCount++;

                    if (board[i, j] is Rook && board[i, j].getIsWhite()) whiteRookCount++;
                    if (board[i, j] is Rook && !board[i, j].getIsWhite()) blackRookCount++;

                    if (board[i, j] is Bishop && board[i, j].getIsWhite())
                    {
                        whiteBishopCount++;
                        isWhiteBishopOnWhiteCell = squareCount % 2 != 0;
                    }
                    if (board[i, j] is Bishop && !board[i, j].getIsWhite())
                    {
                        isBlackBishopOnWhiteCell = squareCount % 2 != 0;
                        blackBishopCount++;
                    }

                    if (board[i, j] is Knight && board[i, j].getIsWhite()) whiteKnightCount++;
                    if (board[i, j] is Knight && !board[i, j].getIsWhite()) blackKnightCount++;
                }
            }
            if (whiteKingCount == 1 && whiteBishopCount < 1 && blackKingCount == 1 && blackBishopCount < 1 && whiteQueenCount < 1 && blackQueenCount < 1 && whitePawnCount < 1 && blackPawnCount < 1 && whiteKnightCount < 1 && blackKnightCount < 1 && whiteRookCount < 1 && blackRookCount < 1) return true;
            else if (
                ((whiteKingCount == 1 && whiteBishopCount == 1 && blackKingCount < 1)
                ||
                (blackKingCount == 1 && blackBishopCount == 1 && whiteKingCount == 1))
                &&
                whiteQueenCount < 1 && blackQueenCount < 1 && whitePawnCount < 1 && blackPawnCount < 1 && whiteKnightCount < 1 && blackKnightCount < 1 && whiteRookCount < 1 && blackRookCount < 1) return true;
            else if (
                ((whiteKingCount == 1 && whiteKnightCount == 1 && blackKingCount < 1)
                ||
                (blackKingCount == 1 && blackKnightCount == 1 && whiteKingCount == 1))
                &&
                whiteQueenCount < 1 && blackQueenCount < 1 && whitePawnCount < 1 && blackPawnCount < 1 && whiteBishopCount < 1 && blackBishopCount < 1 && whiteRookCount < 1 && blackRookCount < 1) return true;
            else if (whiteKingCount == 1 && whiteBishopCount == 1 && blackKingCount == 1 && blackBishopCount == 1 && whiteQueenCount < 1 && blackQueenCount < 1 && whitePawnCount < 1 && blackPawnCount < 1 && whiteKnightCount < 1 && blackKnightCount < 1 && whiteRookCount < 1 && blackRookCount < 1 && (isWhiteBishopOnWhiteCell == isBlackBishopOnWhiteCell)) return true;
            else return false;
        }
    }
    interface IPiece
    {
        Piece[,] move(Piece[,] board, string playerMove);

    }
    class Piece
    {
        bool isWhite;
        string rank;
        public Piece(bool isWhite, string rank)
        {
            this.isWhite = isWhite;
            this.rank = rank;
        }
        public bool getIsWhite()
        {
            return isWhite;
        }
        public int[] getKingPos(Piece[,] board, bool isWhite)
        {
            for (int i = 1; i < board.GetLength(0); i++)
            {
                for (int j = 1; j < board.GetLength(1); j++)
                {
                    if(board[i,j] is King && board[i,j].getIsWhite() == isWhite) return new int[] {i,j};
                }
            }
            return null;
        }
        public bool isLeavingKingInCheck(Piece[,] board, int destinationRow, int destinationCol, int currPosRow, int currPosCol)
        {
            bool isLeavingKingInCheck;
            
            Piece[,] testBoard = new Piece[9, 9];//using a copy of the board to test move
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (i == 0 || j == 0) continue;
                    if (board[i, j] is Piece)
                    {
                        if (board[i, j] is Pawn) testBoard[i, j] = new Pawn(board[i, j].getIsWhite());
                        else if (board[i, j] is Knight) testBoard[i, j] = new Knight(board[i, j].getIsWhite());
                        else if (board[i, j] is Bishop) testBoard[i, j] = new Bishop(board[i, j].getIsWhite());
                        else if (board[i, j] is Queen) testBoard[i, j] = new Queen(board[i, j].getIsWhite());
                        else if (board[i, j] is King) testBoard[i, j] = new King(board[i, j].getIsWhite(), ((King)board[i, j]).getIsMoved());
                        else if (board[i, j] is Rook) testBoard[i, j] = new Rook(board[i, j].getIsWhite(), ((Rook)board[i, j]).getIsMoved());
                    }
                }
            }
            testBoard[destinationRow, destinationCol] = testBoard[currPosRow,currPosCol] is King? new King(testBoard[currPosRow, currPosCol].getIsWhite(),((King)testBoard[currPosRow, currPosCol]).getIsMoved()) :new Pawn(testBoard[currPosRow, currPosCol].getIsWhite());
            testBoard[currPosRow, currPosCol] = null;
            isLeavingKingInCheck = isKingInCheck(testBoard, testBoard[destinationRow, destinationCol].getIsWhite());
            return isLeavingKingInCheck;


        }
        public bool isCheck(Piece[,] board, int row, int col, bool isWhite)
        {
            // row and col is the position of the king!
            //diagonal up left i- j-
            int diff = 1;
            //Console.WriteLine("CHECK TEST =====1=====");
            while (diff < 7 && col - diff > 0 && row - diff > 0)
            {
                int newRow = row - diff;
                int newCol = col - diff;
                if (board[newRow, newCol] is null)
                {
                    diff++;
                    continue;
                }
                if (board[newRow, newCol] is Piece && board[newRow, newCol].getIsWhite() == isWhite) break;
                else if (diff == 1 && (board[newRow, newCol] is King || board[newRow, newCol] is Pawn)) return true;
                else if (board[newRow, newCol] is Queen || board[newRow, newCol] is Bishop) return true;
                else if (board[newRow, newCol] is Piece) break;
                diff++;
            }
            //diagonal up right i-,j+
            //Console.WriteLine("CHECK TEST =====2=====");
            diff = 1;
            while (diff < 7 && col + diff < 9 && row - diff > 0)
            {
                int newRow = row - diff;
                int newCol = col + diff;
                if (board[newRow, newCol] is null)
                {
                    diff++;
                    continue;
                }
                if (board[newRow, newCol] is Piece && board[newRow, newCol].getIsWhite() == isWhite) break;
                else if (diff == 1 && (board[newRow, newCol] is King || board[newRow, newCol] is Pawn)) return true;
                else if (board[newRow, newCol] is Queen || board[newRow, newCol] is Bishop) return true;
                else if (board[newRow, newCol] is Piece) break;
                diff++;
            }
            diff = 1;
            //diagonal down left i+,j-
            //Console.WriteLine("CHECK TEST =====3=====");
            while (diff < 7 && col - diff > 0 && row + diff < 9)
            {
                int newRow = row + diff;
                int newCol = col - diff;
                if (board[newRow, newCol] is null)
                {
                    diff++;
                    continue;
                }
                if (board[newRow, newCol] is Piece && board[newRow, newCol].getIsWhite() == isWhite) break;
                else if (diff == 1 && (board[newRow, newCol] is King || board[newRow, newCol] is Pawn)) return true;
                
                else if (board[newRow, newCol] is Queen || board[newRow, newCol] is Bishop) return true;
                else if (board[newRow, newCol] is Piece) break;
                diff++;
            }
            //diagonal down right i+, j+
            diff = 1;
            //Console.WriteLine("CHECK TEST =====4=====");
            while (diff < 7 && col + diff < 9 && row + diff < 9)
            {
                int newRow = row + diff;
                int newCol = col + diff;
                if (board[newRow, newCol] is null)
                {
                    diff++;
                    continue;
                }
                if (board[newRow, newCol] is Piece && board[newRow, newCol].getIsWhite() == isWhite) break;
                else if (diff == 1 && (board[newRow, newCol] is King || board[newRow, newCol] is Pawn)) return true;
                else if (board[newRow, newCol] is Queen || board[newRow, newCol] is Bishop) return true;
                else if (board[newRow, newCol] is Piece) break;
                diff++;
            }
            //straight up i-,j==col
            //Console.WriteLine("CHECK TEST =====5=====");
            for (int i = row - 1; i > 0; i--)
            {
                if (board[i, col] is null) continue;
                Piece currPiece = board[i, col];
                if (currPiece.getIsWhite() == isWhite) break;
                if (i == row - 1 && currPiece is King) return true;
                else if (currPiece is Rook || currPiece is Queen) return true;
                else if (currPiece is Piece) break;
            }
            //straight down i+ j==col
            //Console.WriteLine("CHECK TEST =====6=====");
            for (int i = row + 1; i < 9; i++)
            {
                if (board[i, col] is null) continue;
                if (board[i, col] is not null && board[i, col] is not Piece) break;
                Piece currPiece = board[i, col];
                if (currPiece.getIsWhite() == isWhite) break;
                if (i == 2 && currPiece is King) return true;
                else if (currPiece is Rook || currPiece is Queen) return true;
                else if (currPiece is Piece) break;
            }
            //right i==row,j+
            //Console.WriteLine("CHECK TEST =====7=====");
            for (int i = col + 1; i < 9; i++)
            {
                //if (board[row, i] is not object) break;
                if (board[row, i] is null) continue;
                Piece currPiece = board[row, i];
                if (currPiece.getIsWhite() == isWhite) break;

                if (i == col + 1 && currPiece is King) return true;
                else if (currPiece is Rook || currPiece is Queen) return true;
                else if (currPiece is Piece) break;
            }
            //left i==row,j-
            //Console.WriteLine("CHECK TEST =====8=====");
            for (int i = col - 1; i > 0; i--)
            {
                //if (board[row, i] is not object) break;
                if (board[row, i] is null) continue;
                Piece currPiece = board[row, i];
                if (currPiece.getIsWhite() == isWhite) break;

                if (i == col - 1 && currPiece is King) return true;
                else if (currPiece is Rook || currPiece is Queen) return true;
                else if (currPiece is Piece) break;
            }
            //Console.WriteLine("CHECK TEST =====9=====");
            //knights:
            if (
                (row + 2 < 9) && (col + 1 < 9) && board[row + 2, col + 1] is Knight && (board[row + 2, col + 1].getIsWhite() != isWhite)
                ||
                (row - 2 > 0) && (col + 1 < 9) && board[row - 2, col + 1] is Knight && (board[row - 2, col + 1].getIsWhite() != isWhite)
                ||
                (row - 2 > 0) && (col - 1 > 0) && board[row - 2, col - 1] is Knight && (board[row - 2, col - 1].getIsWhite() != isWhite)
                ||
                (row + 2 < 9) && (col - 1 > 0) && board[row + 2, col - 1] is Knight && (board[row + 2, col - 1].getIsWhite() != isWhite)
                ||
                (row + 1 < 9) && (col - 2 > 0) && board[row + 1, col - 2] is Knight && (board[row + 1, col - 2].getIsWhite() != isWhite)
                ||
                (row - 1 > 0) && (col - 2 > 0) && board[row - 1, col - 2] is Knight && (board[row - 1, col - 2].getIsWhite() != isWhite)
                ||
                (row + 1 < 9) && (col + 2 < 9) && board[row + 1, col + 2] is Knight && (board[row + 1, col + 2].getIsWhite() != isWhite)
                ||
                (row - 1 > 0) && (col + 2 < 9) && board[row - 1, col + 2] is Knight && (board[row - 1, col + 2].getIsWhite() != isWhite)
                )
            {
                return true;
            }
            //Console.WriteLine("CHECK TEST =====NONE=====");
            return false;
        }
        bool isKingInCheck(Piece[,] board, bool isWhite)
        {
            bool isKingInCheck = false;
            for (int i = 0; i < board.GetLength(0) && !isKingInCheck; i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] is Piece && board[i, j] is King && board[i, j].getIsWhite() == isWhite)
                    {
                        //if (isCheck(board, i, j, isWhite)) isKingInCheck = true;
                        isKingInCheck = isCheck(board, i, j, isWhite);
                        break;
                    }
                }
            }
            return isKingInCheck;
        }
        public bool isValidInput(string input)
        {
            if (input.Length != 4) return false;
            bool isValid = true;
            for (int i = 0; i < 4 && isValid; i++)
            {
                switch (input[i])
                {
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case 'a':
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'e':
                    case 'f':
                    case 'g':
                    case 'h':
                         isValid = true;
                        break;
                    default:
                        isValid = false;
                        break;
                }
            }
            return isValid ;
        }
        
        public string getRank()
        {
            return rank;
        }
        public static int getNumberFromLetter(char letter)
        {
            switch (letter)
            {
                case 'a': return 1;
                case 'b': return 2;
                case 'c': return 3;
                case 'd': return 4;
                case 'e': return 5;
                case 'f': return 6;
                case 'g': return 7;
                case 'h': return 8;
                default:
                    return 0;
            }
        }
        public bool isYourPieceToMove(int turn)
        {
            Console.WriteLine($"You're moving a {(isWhite ? "white": "black")} {rank}.");
            bool legal = !this.isWhite && turn % 2 == 0 || this.isWhite && turn % 2 != 0;
            return legal;
        }
    }
    class Pawn : Piece, IPiece
    {
        bool isLastMoveDouble;
        public Pawn(bool isWhite) : base(isWhite, "pawn") 
        {
            isLastMoveDouble = false;
        }
        public bool getIsLastMoveDouble()
        {
            return isLastMoveDouble;
        }
        public void setIsLastMoveDouble(bool isLastMoveDouble)
        {
            this.isLastMoveDouble = isLastMoveDouble;
        }
        Piece promote(bool isWhite,string newRank)
        {
            switch (newRank)
            {
                case "q":
                    return new Queen(isWhite);
                case "b":
                    return new Bishop(isWhite);
                case "k":
                    return new Knight(isWhite);
                default:
                    return new Queen(isWhite);
            }
        }
       
        public Piece[,] move(Piece[,] board,string playerMove)
        {
            if (!isValidInput(playerMove)) return null;
            int currPosRow = getNumberFromLetter(playerMove[1]);
            int currPosCol = int.Parse(playerMove[0] +"");
            if (board[currPosRow, currPosCol] is null) return null;
            int nextPosRow = getNumberFromLetter(playerMove[3]);
            int nextPosCol = int.Parse(playerMove[2] + "");
            Piece currPiece = board[currPosRow, currPosCol];
            if (currPiece is null) return null;
            Pawn newPiece = new Pawn(currPiece.getIsWhite());
            int movesAllowed = ((newPiece.getIsWhite() && currPosRow == 7) || !newPiece.getIsWhite() && currPosRow == 2) ? 2 : 1;
            double rowDifference = currPosRow - nextPosRow;
            double colDifference = currPosCol - nextPosCol;
            if (Math.Abs(rowDifference) > movesAllowed || Math.Abs(colDifference) >1) return null;//more than 1 square (or 2 if first move)
            if (Math.Abs(colDifference) == 1 && rowDifference == 0) return null;
            else if (currPosRow + 1 < 9 && board[currPosRow + 1, nextPosCol] is Piece && board[nextPosRow, nextPosCol] is Piece && colDifference == 0) return null;
            //en passant capture check:
            else if (Math.Abs(colDifference) == 1 && board[nextPosRow, nextPosCol] is null)
            {
                if (
                    board[currPosRow, currPosCol - 1] is Pawn
                    &&
                    board[currPosRow, currPosCol - 1].getIsWhite() != board[currPosRow, currPosCol].getIsWhite()
                    &&
                    ((Pawn)board[currPosRow, currPosCol - 1]).getIsLastMoveDouble()
                    &&
                    colDifference > 0
                    )
                {
                    board[currPosRow, currPosCol - 1] = null;
                }
                else if (
                   board[currPosRow, currPosCol + 1] is Pawn
                   &&
                   board[currPosRow, currPosCol + 1].getIsWhite() != board[currPosRow, currPosCol].getIsWhite()
                   &&
                   ((Pawn)board[currPosRow, currPosCol + 1]).getIsLastMoveDouble()
                   &&
                    colDifference < 0
                   )
                {
                    board[currPosRow, currPosCol + 1] = null;
                }
                else return null;
            }
            else if (Math.Abs(colDifference) == 0 && board[nextPosRow, nextPosCol] is Piece) return null;
            else if (board[nextPosRow, nextPosCol] is Piece && Math.Abs(colDifference) == 0)
            {
                if (board[nextPosRow, nextPosCol].getIsWhite() == board[currPosRow, currPosCol].getIsWhite()) return null;
                board[nextPosRow, nextPosCol] = board[currPosRow, currPosCol];
                board[currPosRow, currPosCol] = null;
            }
            //direction check
            else if (rowDifference < 0 && newPiece.getIsWhite() || rowDifference > 0 && !newPiece.getIsWhite()) return null;
            //promotion check:
            if (currPiece.getIsWhite() && nextPosRow == 1)
            {
                Console.WriteLine("!=====================PROMOTION===========================!");
                board[nextPosRow, nextPosCol] = newPiece.promote(newPiece.getIsWhite(), "q");
            }
            else if (!currPiece.getIsWhite() && nextPosRow == 8)
            {
                Console.WriteLine("!=====================PROMOTION===========================!");
                board[nextPosRow, nextPosCol] = newPiece.promote(newPiece.getIsWhite(), "q");
            }
            if(Math.Abs(rowDifference) == 2)newPiece.setIsLastMoveDouble(true);
            if (isLeavingKingInCheck(board,nextPosRow,nextPosCol, currPosRow,currPosCol)) return null;
            board[nextPosRow, nextPosCol] = newPiece;
            board[currPosRow, currPosCol] = null;

            return board;
        }
    }
    class Queen: Piece, IPiece
    {
        public Queen(bool isWhite) : base(isWhite, "queen")
        {
        }
        public Piece[,] move(Piece[,] board, string playerMove)
        {
            if (!isValidInput(playerMove)) return null;
            int currPosRow = getNumberFromLetter(playerMove[1]);
            int currPosCol = int.Parse(playerMove[0] + "");
            if (board[currPosRow, currPosCol] is null) return null;
            int nextPosRow = getNumberFromLetter(playerMove[3]);
            int nextPosCol = int.Parse(playerMove[2] + "");
            double rowDifference = currPosRow - nextPosRow;
            double colDifference = currPosCol - nextPosCol;
            if (board[nextPosRow, nextPosCol] is Piece && board[nextPosRow, nextPosCol].getIsWhite() == board[currPosRow, currPosCol].getIsWhite()) return null;// can use a function in the class Piece since this is exactly the same in every Piece
            if(Math.Abs(rowDifference) != Math.Abs(colDifference) && (colDifference != 0 && rowDifference != 0)) return null;
            if (rowDifference < 0 && colDifference == 0)
            {
                for (int i = currPosRow+1; i < nextPosRow; i++) if (board[i, currPosCol] is Piece) return null;
            }
            else if (rowDifference > 0 && colDifference == 0)
            {
                for (int i = currPosRow-1; i > nextPosRow; i--) if (board[i, currPosCol] is Piece) return null;
            }
            else if (colDifference < 0 && rowDifference == 0)
            {
                for (int i = currPosCol+1; i < nextPosCol; i++) if (board[currPosRow, i] is Piece) return null;
            }
            else if (colDifference > 0 && rowDifference == 0)
            {
                for (int i = currPosCol-1; i > nextPosCol; i--) if (board[currPosRow, i] is Piece) return null;
            }
            else
            {
                for (int i = 1; i < Math.Abs(rowDifference) || i < Math.Abs(colDifference); i++)// -1 because its ok to capture piece if its in the destination
                {
                    if ((rowDifference < 0) && (colDifference < 0))
                    {
                        if (board[currPosRow + i, currPosCol + i] is Piece) return null;
                    }
                    else if ((rowDifference < 0) && (colDifference > 0))
                    {
                        if (board[currPosRow + i, currPosCol - i] is Piece) return null;
                    }
                    else if ((rowDifference > 0) && (colDifference > 0))
                    {
                        if (board[currPosRow - i, currPosCol - i] is Piece) return null;
                    }
                    else if ((rowDifference > 0) && (colDifference < 0))
                    {
                        if (board[currPosRow - i, currPosCol + i] is Piece) return null;
                    }
                    else return null;
                }
            }
            if (isLeavingKingInCheck(board, nextPosRow, nextPosCol, currPosRow, currPosCol)) return null;//checking if this move is leaving the king in check
            board[nextPosRow, nextPosCol] = new Queen(board[currPosRow, currPosCol].getIsWhite());
            board[currPosRow, currPosCol] = null;
            return board;
        }
    }
    class Rook : Piece, IPiece
    {
        bool isMoved;
        public Rook(bool isWhite) : base(isWhite, "rook")
        {
            isMoved = false;
        }
        public Rook(bool isWhite, bool isMoved) : base(isWhite, "rook")
        {
            this.isMoved = isMoved;
        }
        public bool getIsMoved()
        {
            return isMoved;
        }
        public void setIsMoved(bool isMoved)
        {
            this.isMoved = isMoved;
        }
        public Piece[,] move(Piece[,] board, string playerMove)
        {
            if (!isValidInput(playerMove)) return null;
            int currPosRow = getNumberFromLetter(playerMove[1]);
            int currPosCol = int.Parse(playerMove[0] + "");
            if (board[currPosRow, currPosCol] is null) return null;
            int nextPosRow = getNumberFromLetter(playerMove[3]);
            int nextPosCol = int.Parse(playerMove[2] + "");
            double rowDifference = currPosRow - nextPosRow;
            double colDifference = currPosCol - nextPosCol;
            if (currPosRow != nextPosRow && currPosCol != nextPosCol) return null;//only one of these can be different
            else if (rowDifference < 0)
            {
                for (int i = currPosRow + 1; i < nextPosRow; i++) if (board[i, currPosCol] is Piece) return null;
            }
            else if (rowDifference > 0)
            {
                for (int i = currPosRow - 1; i > nextPosRow; i--) if (board[i, currPosCol] is Piece) return null;
            }
            else if (colDifference < 0)
            {
                for (int i = currPosCol + 1; i < nextPosCol; i++) if (board[currPosRow, i] is Piece) return null;
            }
            else if (colDifference > 0)
            {
                for (int i = currPosCol - 1; i > nextPosCol; i--) if (board[currPosRow, i] is Piece) return null;
            }
            if (board[nextPosRow, nextPosCol] is Piece && board[nextPosRow, nextPosCol].getIsWhite() == board[currPosRow, currPosCol].getIsWhite()) return null;
            if (isLeavingKingInCheck(board, nextPosRow, nextPosCol, currPosRow, currPosCol)) return null;//checking if this move is leaving the king in check
            board[nextPosRow, nextPosCol] = new Rook(board[currPosRow, currPosCol].getIsWhite(),true);
            board[currPosRow, currPosCol] = null;
            return board;
        }

    }
    class Knight: Piece, IPiece
    {
        public Knight(bool isWhite) : base(isWhite, "knight")
        {
        }

        public Piece[,] move(Piece[,] board, string playerMove)
        {
            if (!isValidInput(playerMove)) return null;
            int currPosRow = getNumberFromLetter(playerMove[1]);
            int currPosCol = int.Parse(playerMove[0] + "");
            if (board[currPosRow, currPosCol] is null) return null;
            int nextPosRow = getNumberFromLetter(playerMove[3]);
            int nextPosCol = int.Parse(playerMove[2] + "");
            if (nextPosRow > 8 || nextPosCol > 8 || nextPosRow < 1 || nextPosCol < 1) return null;
            double rowDifference = currPosRow - nextPosRow;
            double colDifference = currPosCol - nextPosCol;
            if(Math.Abs(rowDifference) >2 || Math.Abs(rowDifference)<1 || Math.Abs(colDifference) >2 || Math.Abs(colDifference)<1) return null;
            else
            {
                if (board[nextPosRow, nextPosCol] is Piece || board[nextPosRow, nextPosCol] == null)
                {
                    if (board[nextPosRow, nextPosCol] is Piece && board[nextPosRow, nextPosCol].getIsWhite() == board[currPosRow, currPosCol].getIsWhite()) return null;
                    if (Math.Abs(rowDifference) == Math.Abs(colDifference)) return null;
                    if (isLeavingKingInCheck(board, nextPosRow, nextPosCol, currPosRow, currPosCol)) return null;//checking if this move is leaving the king in check
                    board[nextPosRow, nextPosCol] = new Knight(this.getIsWhite());
                    board[currPosRow, currPosCol] = null;
                    return board;
                }
                    return null;
            }
        }
    }
    class Bishop : Piece, IPiece
    {
        public Bishop(bool isWhite) : base(isWhite, "bishop")
        {
        }
        public Piece[,] move(Piece[,] board, string playerMove)
        {
            if (!isValidInput(playerMove)) return null;
            int currPosRow = getNumberFromLetter(playerMove[1]);
            int currPosCol = int.Parse(playerMove[0] + "");
            if (board[currPosRow, currPosCol] is null) return null;
            int nextPosRow = getNumberFromLetter(playerMove[3]);
            int nextPosCol = int.Parse(playerMove[2] + "");
            double rowDifference = currPosRow - nextPosRow;
            double colDifference = currPosCol - nextPosCol;
            if (Math.Abs(colDifference) != Math.Abs(rowDifference)) return null;
            for (int i = 1; i < Math.Abs(rowDifference) || i < Math.Abs(colDifference); i++)// -1 because its ok to capture piece if its in the destination
            {
                if ((rowDifference < 0) && (colDifference<0))
                {
                    if (board[currPosRow+i, currPosCol+i] is Piece) return null;
                }else if((rowDifference < 0) && (colDifference > 0))
                {
                    if (board[currPosRow+i, currPosCol-i] is Piece) return null;
                }
                else if ((rowDifference > 0) && (colDifference > 0))
                {
                    if (board[currPosRow - i, currPosCol - i] is Piece) return null;
                }
                else if ((rowDifference > 0) && (colDifference < 0))
                {
                    if (board[currPosRow - i, currPosCol + i] is Piece) return null;
                }
            }
            if (board[nextPosRow, nextPosCol] is Piece && board[nextPosRow, nextPosCol].getIsWhite() == board[currPosRow, currPosCol].getIsWhite()) return null;
            if (isLeavingKingInCheck(board, nextPosRow, nextPosCol, currPosRow, currPosCol)) return null;//checking if this move is leaving the king in check
            board[nextPosRow, nextPosCol] = new Bishop(board[currPosRow, currPosCol].getIsWhite());
            board[currPosRow, currPosCol] = null;
            return board;
        }
    }
    class King : Piece, IPiece
    {
        bool isInCheck;
        bool isMoved;
        public King(bool isWhite) : base(isWhite, "king")
        {
            isMoved = false;
            isInCheck = false;
        }
        public King(bool isWhite,bool isMoved) : base(isWhite, "king")
        {
            this.isMoved = isMoved;
            isInCheck = false;
        }
        public bool getIsMoved()
        {
            return isMoved;
        }
        public void setIsMoved(bool isMoved)
        {
            this.isMoved = isMoved;
        }
        public bool getIsInCheck()
        {
            return isInCheck;
        }
        public void setIsInCheck(bool isInCheck)
        {
           this.isInCheck = isInCheck;
        }
        Piece[,] castle(Piece[,] board, int row, int col,int destinationRow,int destinationCol, bool isWhite)
        {
            if (board[row, col].isCheck(board, row, col, isWhite)) return null;
            for (int i = 1; i <= 2; i++)
            {
                //small castling
                if (destinationCol > col)
                {
                    if (board[row, col + i] is Piece) return null;
                    board[row, col + i] = new King(isWhite);
                    if (((King)board[row, col+i]).isNextSquareThreatened(board, row, col, isWhite))
                    {
                        board[row, col+i] = null;
                        return null;
                    }
                    board[row, 6] = new Rook(isWhite, true);
                }
                //big castle
                else
                {
                    if (board[row, col - i] is Piece) return null;
                    if (board[row, 2] is Piece) return null;
                    board[row, col - i] = new King(isWhite);
                    if (((King)board[row, col - i]).isNextSquareThreatened(board, row, col, isWhite))
                    {
                        Console.WriteLine("castling " + row + "|" + (col-i));
                        board[row, col - i] = null;
                        return null;
                    }
                    board[row, 4] = new Rook(isWhite, true);
                }
            }
            board[row, destinationCol] = new King(isWhite, true);
            board[row, destinationCol > col ? 8 : 1] = null;
            board[row, 5] = null;
            return board;
        }
        public Piece[,] move(Piece[,] board, string playerMove)
        {
            if (!isValidInput(playerMove)) return null;
            int currPosRow = getNumberFromLetter(playerMove[1]);
            int currPosCol = int.Parse(playerMove[0] + "");
            if (board[currPosRow, currPosCol] is null) return null;
            int nextPosRow = getNumberFromLetter(playerMove[3]);
            int nextPosCol = int.Parse(playerMove[2] + "");
            double rowDifference = currPosRow - nextPosRow;
            double colDifference = currPosCol - nextPosCol;
            if (board[nextPosRow, nextPosCol] is Piece && board[nextPosRow, nextPosCol].getIsWhite() == board[currPosRow, currPosCol].getIsWhite()) return null;
            if (isTryingToCastle(board, currPosRow, currPosCol, nextPosRow, nextPosCol, board[currPosRow, currPosCol].getIsWhite()))
            {
                return castle(board, currPosRow, currPosCol, nextPosRow, nextPosCol, board[currPosRow, currPosCol].getIsWhite());
            }
            if ((Math.Abs(rowDifference) > 1) || (Math.Abs(colDifference) > 1)) return null;
            if (isLeavingKingInCheck(board, nextPosRow, nextPosCol, currPosRow, currPosCol)) return null;//checking if this move is leaving the king in check
            board[nextPosRow, nextPosCol] = new King(board[currPosRow, currPosCol].getIsWhite(),true);
            board[currPosRow, currPosCol] = null;
            return board;
        }
        bool isTryingToCastle(Piece[,] board, int row, int col, int destinationRow, int destinationCol, bool isWhite)
        {
          
            if (Math.Abs(col-destinationCol)!=2) return false;
            if (row == (isWhite ? 8 : 1) && (col == 5) && (destinationRow == row))
            {
                bool isSmallCastling = destinationCol > col;
                if ((isSmallCastling && board[row,8] is null) || (!isSmallCastling && board[row, 1] is null)) return false;//check if the Rook is even there
                Rook rookPiece = isSmallCastling ? ((Rook)board[row, 8]) : (Rook)board[row, 1];// determain which Rook it is
                if (rookPiece.getIsMoved() || ((King)board[row, col]).getIsMoved()) return false;//check if any of the pieces moved before
                else return true;
            }
            else return false;
        }
        public bool isNextSquareThreatened(Piece[,] board, int row, int col, bool isWhite)
        {
            //diagonal up left i- j-
            int diff = 1;
            //Console.WriteLine("moving king =====1=====");
            while (diff < 7 && col - diff > 0 && row - diff > 0)
            {
                int newRow = row - diff;
                int newCol = col - diff;
                if (board[newRow, newCol] is null)
                {
                    diff++;
                    continue;
                }
                if (board[newRow, newCol] is Piece && board[newRow, newCol].getIsWhite() == isWhite) break;
                else if (diff == 1 && (board[newRow, newCol] is King || (board[newRow, newCol] is Pawn && board[newRow, newCol].getIsWhite() == false))) return true;
                else if (board[newRow, newCol] is Queen || board[newRow, newCol] is Bishop) return true;
                else if (board[newRow, newCol] is Piece) break;
                diff++;
            }
            //diagonal up right i-,j+
            //Console.WriteLine("moving king =====2=====");
            diff = 1;
            while (diff < 7 && col + diff < 9 && row - diff > 0)
            {
                int newRow = row - diff;
                int newCol = col + diff;
                if (board[newRow, newCol] is null)
                {
                    diff++;
                    continue;
                }
                if (board[newRow, newCol] is Piece && board[newRow, newCol].getIsWhite() == isWhite) break;
                else if (diff == 1 && (board[newRow, newCol] is King || (board[newRow, newCol] is Pawn && board[newRow, newCol].getIsWhite() == false))) return true;//either Ping or black Pawn
                else if (board[newRow, newCol] is Queen || board[newRow, newCol] is Bishop) return true;
                else if (board[newRow, newCol] is Piece) break;
                diff++;
            }
            diff = 1;
            //diagonal down left i+,j-
            //Console.WriteLine("moving king =====3=====");
            while (diff < 7 && col - diff > 0 && row + diff < 9)
            {
                int newRow = row + diff;
                int newCol = col - diff;
                if (board[newRow, newCol] is null)
                {
                    diff++;
                    continue;
                }
                if (board[newRow, newCol] is Piece && board[newRow, newCol].getIsWhite() == isWhite) break;
                else if (diff == 1 && (board[newRow, newCol] is King || (board[newRow, newCol] is Pawn && board[newRow, newCol].getIsWhite() == true))) return true;
                else if (board[newRow, newCol] is Queen || board[newRow, newCol] is Bishop) return true;
                else if (board[newRow, newCol] is Piece) break;
                diff++;
            }
            //diagonal down right i+, j+
            diff = 1;
            //Console.WriteLine("moving king =====4=====");
            while (diff < 7 && col + diff < 9 && row + diff < 9)
            {
                int newRow = row + diff;
                int newCol = col + diff;
                if (board[newRow, newCol] is null)
                {
                    diff++;
                    continue;
                }
                if (board[newRow, newCol] is Piece && board[newRow, newCol].getIsWhite() == isWhite) break;
                else if (diff == 1 && (board[newRow, newCol] is King || (board[newRow, newCol] is Pawn && board[newRow, newCol].getIsWhite() == true))) return true;
                else if (board[newRow, newCol] is Queen || board[newRow, newCol] is Bishop) return true;
                else if (board[newRow, newCol] is Piece) break;
                diff++;
            }
            //straight up i-,j==col
            //Console.WriteLine("moving king =====5=====");
            for (int i = row - 1; i > 0; i--)
            {
                if (board[i, col] is not object) break;
                if (board[i, col] is null) continue;
                Piece currPiece = board[i, col];
                if (currPiece.getIsWhite() == isWhite) break;

                if (i == row - 1 && currPiece is King) return true;
                else if (currPiece is Rook || currPiece is Queen) return true;
            }
            // right i==row, j+
            //Console.WriteLine("moving king =====6=====");
            for (int i = col + 1; i < 9; i++)
            {
                if (board[row, i] is not object) break;
                if (board[row, i] is null) continue;
                Piece currPiece = board[row, i];
                if (currPiece.getIsWhite() == isWhite) break;

                if (i == row - 1 && currPiece is King) return true;
                else if (currPiece is Rook || currPiece is Queen) return true;
            }
            //straight down i+ j==col
            //Console.WriteLine("moving king =====7=====");
            for (int i = row + 1; i < 9; i++)
            {
                if (board[i, col] is not object) break;
                if (board[i, col] is null) continue;
                Piece currPiece = board[i, col];
                if (currPiece.getIsWhite() == isWhite) break;
                if (i == 2 && currPiece is King) return true;
                else if (currPiece is Rook || currPiece is Queen) return true;
            }
            //left i==row, j-
            //Console.WriteLine("moving king =====8=====");
            for (int i = row - 1; i > 0; i--)
            {
                if (board[row, i] is not object) break;
                if (board[row, i] is null) continue;
                Piece currPiece = board[row, i];
                if (currPiece.getIsWhite() == isWhite) break;

                if (i == row - 1 && currPiece is King) return true;
                else if (currPiece is Rook || currPiece is Queen) return true;
            }
            //Console.WriteLine("moving king =====8=====");
            if (
                (row + 2 < 9) && (col + 1 < 9) && board[row + 2, col + 1] is Knight && (board[row + 2, col + 1].getIsWhite() != isWhite)
                ||
                (row - 2 > 0) && (col + 1 < 9) && board[row - 2, col + 1] is Knight && (board[row - 2, col + 1].getIsWhite() != isWhite)
                ||
                (row - 2 > 0) && (col - 1 > 0) && board[row - 2, col - 1] is Knight && (board[row - 2, col - 1].getIsWhite() != isWhite)
                ||
                (row + 2 < 9) && (col - 1 > 0) && board[row + 2, col - 1] is Knight && (board[row + 2, col - 1].getIsWhite() != isWhite)
                ||
                (row + 1 < 9) && (col - 2 > 0) && board[row + 1, col - 2] is Knight && (board[row + 1, col - 2].getIsWhite() != isWhite)
                ||
                (row - 1 > 0) && (col - 2 > 0) && board[row - 1, col - 2] is Knight && (board[row - 1, col - 2].getIsWhite() != isWhite)
                ||
                (row + 1 < 9) && (col + 2 < 9) && board[row + 1, col + 2] is Knight && (board[row + 1, col + 2].getIsWhite() != isWhite)
                ||
                (row - 1 > 0) && (col + 2 < 9) && board[row - 1, col + 2] is Knight && (board[row - 1, col + 2].getIsWhite() != isWhite)
                )
            {
                return true;
            }
            return false;
        }
    }
}
