using System;
using System.Windows.Forms;

namespace Notaciones_polakas
{
    public partial class Form1 : Form
    {
        //model to PolishNotation (tree) class
        public class Node
        {
            public char Val { get; set; }
            public Node LeftChild { get; set; }
            public Node RightChild { get; set; }

            public Node(char val)
            {
                this.Val = val;
            }

            public bool hasLeft() { return LeftChild != null; }
            public bool hasRight() { return RightChild != null; }
        }

        //model to stack class
        public class Element
        {
            public Node Val { get; set; }
            public Element Next { get; set; }

            public Element(Node val)
            {
                this.Val = val;
            }
        }

        public class Num
        {
            public double Val { get; set; }
            public Num Next { get; set; }

            public Num(double val)
            {
                this.Val = val;
            }
        }

        public class StackNumbers
        {
            public Num first;

            public void push(Num newValue)
            {
                if (isEmpty())
                    first = newValue;
                else
                {
                    newValue.Next = first;
                    first = newValue;
                }
            }

            public Num pop()
            {
                if (!isEmpty())
                {
                    Num temp = first;
                    first = first.Next;
                    return temp;
                }

                return null;
            }

            public Num peek() { return first; }

            public bool isEmpty() { return first == null; }

            public string list()
            {
                string stack = "";
                Num temp = first;
                while(temp != null)
                {
                    stack = temp.Val + "\n" + stack;
                    temp = temp.Next;
                }
                return stack;
            }
        }

        public class Queue
        {
            private Element first;
            private Element last;

            public Element peek() { return first; }

            public void add(Element newElement)
            {
                if (first != null)
                {
                    last.Next = newElement;
                    last = newElement;
                }
                else
                {
                    first = newElement;
                    last = newElement;
                }
            }

            public Element poll()
            {
                if (first != null)
                {
                    if (first.Next != null)
                    {
                        Element temp = first;
                        first = first.Next;
                        return temp;
                    }
                    else
                    {
                        Element temp = first;
                        first = null;
                        last = null;
                        return temp;
                    }
                }
                return null;
            }

            public Element pollLast()
            {
                if (first != null)
                {
                    if (first.Next != null)
                    {
                        Element temp = first;
                        while (temp.Next.Next != null)
                            temp = temp.Next;
                        Element result = last;
                        last = temp;
                        temp.Next = null;
                        return result;
                    }
                    else
                    {
                        Element temp = first;
                        first = null;
                        last = null;
                        return temp;
                    }
                }
                return null;
            }

            public string list()
            {
                if (first != null)
                {
                    string processString = first.ToString();
                    Element temp = first;
                    while (temp.Next != null)
                    {
                        processString += temp.ToString();
                        temp = temp.Next;
                    }
                    return processString;
                }
                else
                    return "No se ha agregado ningún proceso a la cola";
            }
        }

        public class PolishNotation
        {
            private Queue queue;
            public char[] Expresion;

            public StackNumbers stack { get; }
            private Node root;
            private char[] operands = { '/', '*', '+', '-' };

            public PolishNotation(string expresion)
            {
                this.queue = new Queue();
                this.Expresion = new char[expresion.Length];

                stack = new StackNumbers();

                expresion = expresion.Trim();
                for (int i = 0; i < expresion.Length; i++)
                    this.Expresion[i] = expresion[i];
            }

            public void generateTree()
            {
                for (int i = 0; i < operands.Length; i += 2)
                {
                    for (int j = 0; j < Expresion.Length; j++)
                    {
                        if (Expresion[j] == operands[i] || Expresion[j] == operands[i + 1])
                        {
                            Node root = new Node(Expresion[j]);
                            Node left;
                            Node right;
                            try {
                                if (Expresion[j - 1] == '|' && Expresion[j + 1] == '|' && (i == 2 || i == 3))
                                {
                                    left = queue.pollLast().Val;
                                    right = queue.poll().Val;
                                }
                                else
                                {
                                    if (char.IsNumber(Expresion[j - 1]))
                                    {
                                        left = new Node(Expresion[j - 1]);
                                    }
                                    else if (Expresion[j - 1] == '|')
                                    {
                                        left = queue.poll().Val;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Caracter izquierdo incorrecto");
                                        return;
                                    }

                                    if (Char.IsNumber(Expresion[j + 1]))
                                    {
                                        right = new Node(Expresion[j + 1]);
                                    }
                                    else if (Expresion[j + 1] == '|')
                                    {
                                        right = queue.poll().Val;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Caracter derecho incorrecto");
                                        return;
                                    }
                                }

                                root.LeftChild = left;
                                root.RightChild = right;
                                Expresion[j] = '|';
                                Expresion[j - 1] = '|';
                                Expresion[j + 1] = '|';
                                j++;

                                queue.add(new Element(root));
                            } catch (Exception err) {
                                Console.WriteLine("Fuera de los límites del arreglo");
                                Console.WriteLine(err);
                                return;
                            }
                        }
                    }
                }

                root = queue.poll().Val;
            }

            public string getPreOrder()
            {
                string preOrder = "";

                generatePreOrder(root, ref preOrder);

                return preOrder;
            }

            public string getPostOrder()
            {
                string postOrder = "PostOrder:   ";

                generatePostOrder(root, ref postOrder);

                return postOrder;
            }

            public string getInOrder()
            {
                string inOrder = "InOrder:   ";

                generateInOrder(root, ref inOrder);

                return inOrder;
            }

            public void generatePreOrder(Node currentRoot, ref string str)
            {
                str += currentRoot.Val + "";
                if (currentRoot.hasLeft())
                    generatePreOrder(currentRoot.LeftChild, ref str);

                if (currentRoot.hasRight())
                    generatePreOrder(currentRoot.RightChild, ref str);
            }

            public void generatePostOrder(Node currentRoot, ref string str)
            {
                if (currentRoot.hasLeft())
                    generatePostOrder(currentRoot.LeftChild, ref str);

                if (currentRoot.hasRight())
                    generatePostOrder(currentRoot.RightChild, ref str);

                str += currentRoot.Val + " ";
            }

            public void generateInOrder(Node currentRoot, ref string str)
            {
                if (currentRoot.hasLeft())
                    generateInOrder(currentRoot.LeftChild, ref str);

                str += currentRoot.Val + " ";

                if (currentRoot.hasRight())
                    generateInOrder(currentRoot.RightChild, ref str);


            }

            public void evaluatePreOrder(char operandOrNum)
            {
                if(char.IsNumber(operandOrNum))
                {
                    stack.push(new Num(Convert.ToInt32(operandOrNum + "")));
                }
                else
                {
                    double x = stack.pop().Val;
                    double y = stack.pop().Val;

                    stack.push(new Num(getOperationResult(operandOrNum, x, y)));
                }
            }

            private double getOperationResult(char operand, double x, double y)
            {
                switch (operand)
                {
                    case '+':
                        return x + y;
                    case '-':
                        return x - y;
                    case '/':
                        return x / y;
                    case '*':
                        return x * y;
                    default:
                        throw new Exception("Operdor inválido");
                }
            }
        }

        PolishNotation notation;
        string preOrder;
        int index;
        int indexPost;
        public Form1()
        {
            InitializeComponent();
            preOrder = "";
        }

        public void validateExpresion()
        {
            //Method that validate the users don´t send others characters, only numbers and * / + -, delete
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notation = new PolishNotation(txtExpresion.Text);
            notation.generateTree();
            preOrder = notation.getPreOrder();

            lblPreOrder.Text = "PreOrder:   " + preOrder;
            lblPostOrder.Text = notation.getPostOrder();
            lblInOrder.Text = notation.getInOrder();
        }

        private void btnEvaluatePreOrder_Click(object sender, EventArgs e)
        {
            index = preOrder.Length - 1;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            notation.evaluatePreOrder(preOrder[index]);
            txtStackNumbers.Text = notation.stack.list();
            lblCurrent.Text = preOrder[index] + "";
            index--;
            if (index < 0)
                timer.Stop();
        }
    }
}
