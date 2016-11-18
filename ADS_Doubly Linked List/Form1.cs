using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADS_Doubly_Linked_List
{
    public partial class Form1 : Form
    {

        // Double linked lists are almost the same as linked lists except they have more
        // flexibility and more features than linked lists.
        // Doubly linked lists are also made up of Nodes and Links. However, unlike in singly linked lists, the
        // doubly Linked Lists have two link references.One link references the previous node while the other
        // link references the node after it.

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            DoublyLinkedList dll = new DoublyLinkedList();

            //add new nodes
            dll.AddNode("Tom");
            dll.AddNode("Jack");
            dll.AddNode("Mary");

            //print nodes
            txtOutput.Text = dll.PrintNode();
        }

        class Node
        {
            public Node prev, next; // to store the links
            public object data; // to store the data in a node
            public Node()
            {
                this.prev = null;
                this.next = null;
            }
            public Node(object data)
            {
                this.data = data;
                this.prev = null;
                this.next = null;
            }
            public Node(object data, Node prev)
            {
                this.data = data;
                this.prev = prev;
                this.next = null;
            }
            public Node(object data, Node prev, Node next)
            {
                this.data = data;
                this.prev = prev;
                this.next = next;
            }
        }

        class DoublyLinkedList
        {
            public Node head;
            public void AddNode(object n) // add a new node 
            {
                if (head == null)
                {
                    head = new Node(n);//head is pointed to the 1st node in list
                     
                }
                else
                {
                    Node current = head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = new Node(n, current); //current is pointed to the newly added node 
                }
            }
            public String PrintNode() // print nodes
            {
                String Output = "";
                Node printNode = head;
                if (printNode != null)
                {
                    while (printNode != null)
                    {
                        Output += printNode.data.ToString() + "\r\n";
                        printNode = printNode.next;
                    }
                }
                else
                {
                    Output += "No items in Doubly Linked List";
                }
                return Output;
            }
        }
    }
}
