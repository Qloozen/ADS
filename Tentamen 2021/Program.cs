using System;
using System.Collections.Generic;

namespace Tentamen_2021
{
    class Program
    {
        // UITWERKINGEN VAN 2 EN 3 STAAN IN LOSSE FILES, OPDRACHT 3 STAAT HIERIN
        static void Main(string[] args)
        {
            //Opdracht1(); // MarbleGame
            //Opdracht2(); //Cloning linkedlist
            Opdracht3(); //Calculation Booleans
        }

        static void Opdracht1() {
            GameNode root = new GameNode(5, true);
            System.Console.WriteLine(root.CountPlayerWins(true));
            //System.Console.WriteLine(root.CountPlayerWins(false));
        }

        static void Opdracht2() {
            ListNode<string> head = new ListNode<string>(null, "first");
            ListNode<string> second = new ListNode<string>(head, "second");
            ListNode<string> third = new ListNode<string>(second, "third");
            ListNode<string> fourth = new ListNode<string>(third, "fouth");

            System.Console.WriteLine(head); // first second third fourt

            ListNode<string> shallowCopy = head;
            ListNode<string> deepCopy = (ListNode<string>) head.Clone();

            head.ReplaceAt(1, "replaced");

            ListNode<string> fifth = new ListNode<string>(fourth, "fifth");

            System.Console.WriteLine(shallowCopy);// first replaced third fourth fifth
            System.Console.WriteLine(deepCopy); // first second third fourth
        }
    
        static bool evaluate(string expr) {
            char[] chars = expr.ToCharArray();
            Stack<char> stack = new Stack<char>();
            
            foreach(char c in chars) {
                if (c == '&') {
                    if (stack.Pop() == stack.Pop()) {
                        stack.Push('t');
                    } else {
                        stack.Push('f');
                    }
                }
                else if (c == '!') {
                    if(stack.Pop() == 'f') {
                        stack.Push('t');
                    } else {
                        stack.Push('f');
                    }
                }
                else if (c == '|') {
                    if (stack.Pop() == 't' || stack.Pop() == 't') {
                        stack.Push('t');
                    } else {
                        stack.Push('f');
                    }
                }
                else if (c == '?') {
                    stack.Pop();
                    char OptionB = stack.Pop();
                    char OptionA = stack.Pop();
                    char Check = stack.Pop();
                    if (Check == 'f'){
                         stack.Push(OptionB);
                    } else {
                        stack.Push(OptionA);
                    }
                }
                else {
                    stack.Push(c);
                }
            }
    
            if (stack.Pop() == 't') return true;
            if (stack.Pop() == 'f') return false;
            return false;
        }

        static void Opdracht3() {
            string example1 = "tf!&"; //true && ! false
            System.Console.WriteLine(evaluate(example1));
        }
    }
}
