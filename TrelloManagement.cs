using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrelloApps
{
    public partial class TrelloManagement : Form
    {
        public TrelloManagement()
        {
            InitializeComponent();
        }
        public class TrelloCard
        {
            public TrelloCard(string title)
            {
                Title = title;
            }

            public string Title { get; set; }

        }
        public class TrelloList
        {
            public string Name { get; set; }
            public LinkedList<TrelloCard> Cards { get; set; }

            public TrelloList(string name)
            {
                Name = name;
                Cards = new LinkedList<TrelloCard>();
            }
        }
        public class TrelloBoard
        {
            public string Name { get; set; }
            public LinkedList<TrelloList> Lists { get; set; }
            

            public TrelloBoard(string name)
            {
                Name = name;
                Lists = new LinkedList<TrelloList>();
            }

            public void AddList(string listName)
            {

                var newList = new TrelloList(listName);
                Lists.AddLast(newList);
            }

            public void AddCardToList(TrelloList list, string title)
            {
                var newCard = new TrelloCard(title);
                list.Cards.AddLast(newCard);
            }

            internal void AddCardToList(TrelloList selectedList)
            {
                throw new NotImplementedException();
            }
        }
        private LinkedList<TrelloBoard> ListBoards = new LinkedList<TrelloBoard>();








        private void bttnAddBoard_Click(object sender, EventArgs e)
        {
            string newBoardName = txtBoard.Text;
            if (string.IsNullOrWhiteSpace(newBoardName))
            {
                MessageBox.Show("Vui lòng nhập tên bảng trước khi thêm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListBoard.Items.Add(newBoardName);

            txtBoard.Text = " ";

        }

        private void btnDelBoards_Click(object sender, EventArgs e)
        {
            if (ListBoard.SelectedIndex != -1)
            {
                ListBoard.Items.RemoveAt(ListBoard.SelectedIndex);
            }
            else
            {

                MessageBox.Show("Vui lòng chọn một mục để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddListCards_Click(object sender, EventArgs e)
        {
            if (ListBoard.SelectedIndex != -1)
            {
                string newCardName = textBListCards.Text;
                if (string.IsNullOrWhiteSpace(newCardName))
                {
                    MessageBox.Show("Vui lòng nhập tên thẻ trước khi thêm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                listCards.Items.Add(newCardName);

                textBListCards.Text = " ";
            }
            else
            {
                MessageBox.Show("Xin hãy chọn một bảng trong danh sách bảng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnDelListCards_Click(object sender, EventArgs e)
        {
            if (listCards.SelectedIndex != -1)
            {
                listCards.Items.RemoveAt(listCards.SelectedIndex);
            }
            else
            {

                MessageBox.Show("Vui lòng chọn một mục để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddCards_Click(object sender, EventArgs e)
        {
            if (ListBoard.SelectedIndex == -1)
            {
                MessageBox.Show("Xin hãy chọn một bảng trong danh sách.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listCards.SelectedIndex == -1)
            {
                MessageBox.Show("Xin hãy chọn danh sách thẻ bạn muốn xem.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string newCard = textBCards.Text;
            if (string.IsNullOrWhiteSpace(newCard))
            {
                MessageBox.Show("Vui lòng nhập tên thẻ trước khi thêm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cards.Items.Add(newCard);

            textBCards.Text = " ";
        }

        private void btnDelCards_Click(object sender, EventArgs e)
        {
            if (Cards.SelectedIndex != -1)
            {
                Cards.Items.RemoveAt(Cards.SelectedIndex);
            }
            else
            {

                MessageBox.Show("Vui lòng chọn một mục để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private LinkedList<TrelloBoard> ListBoardss = new LinkedList<TrelloBoard>();
        private LinkedList<TrelloList> CurrentLists = new LinkedList<TrelloList>();
        private LinkedList<TrelloCard> CurrentCards = new LinkedList<TrelloCard>();

        private void ListBoard_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveCurrentState();

           
            int selectedBoardIndex = ListBoard.SelectedIndex;
            if (selectedBoardIndex >= 0 && selectedBoardIndex < ListBoards.Count)
            {
                TrelloBoard selectedBoard = ListBoards.ElementAt(selectedBoardIndex);
                DisplayListsAndCards(selectedBoard);
            }
        }

        private void SaveCurrentState()
        {
            CurrentLists.Clear();
            CurrentCards.Clear();

            if (listCards.SelectedIndex != -1)
            {
                int selectedBoardIndex = ListBoard.SelectedIndex;
                int selectedListIndex = listCards.SelectedIndex;

                if (selectedBoardIndex >= 0 && selectedBoardIndex < ListBoards.Count &&
            selectedListIndex >= 0 && selectedListIndex < ListBoards.ElementAt(selectedBoardIndex).Lists.Count)
                {
                    TrelloBoard selectedBoard = ListBoards.ElementAt(selectedBoardIndex);
                    TrelloList selectedList = selectedBoard.Lists.ElementAt(selectedListIndex);
                    CurrentLists.AddLast(selectedList);

                    foreach (TrelloCard card in selectedList.Cards)
                    {
                        CurrentCards.AddLast(card);
                    }
                }
            }
        }

        private void DisplayListsAndCards(TrelloBoard selectedBoard)
        {
            listCards.Items.Clear();
            foreach (TrelloList list in selectedBoard.Lists)
            {
                listCards.Items.Add(list.Name);
            }
            DisplayCards();
        }

        private void DisplayCards()
        {
            Cards.Items.Clear();
            foreach (TrelloCard card in CurrentLists.First().Cards)
            {
                Cards.Items.Add(card.Title);
            }
        }

    }
}      
    

