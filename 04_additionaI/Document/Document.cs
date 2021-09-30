
namespace Classes
{
    class Document
    {
        // Поля
        Title title;
        Body body;
        Footer footer;
        //Будем передавать єкземпляры
        public Document(Title titles, Body bodys, Footer footers)
        {
            this.title = titles;
            this.body = bodys;
            this.footer = footers;
        }

        public void Show()
        {
            this.title.Show();
            this.body.Show();
            this.footer.Show();
        }
    }
}
