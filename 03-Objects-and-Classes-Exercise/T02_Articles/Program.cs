namespace T02_Articles;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var articleInfo = input.Split(", ").ToArray();
        var title = articleInfo[0];
        var content = articleInfo[1];
        var author = articleInfo[2];
        
        Article article = new Article(title, content, author);
        
        var n = int.Parse(Console.ReadLine());

        for (var i = 0; i < n; i++)
        {
            var arr = Console.ReadLine().Split(": ").ToArray();
            
            var command = arr[0];
            var token = arr[1];
            switch (command)
            {
                case "Edit":
                    article.Edit(token);
                    break;
                case "ChangeAuthor":
                    article.ChangeAuthor(token);
                    break;
                case "Rename":
                    article.Rename(token);
                    break;
            }
            
        }
        Console.WriteLine(article.ToString());
    }
}

class Article
{
    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public string Title { get; set; }
    public string Content { get; set; }
    public  string Author { get; set; }

    public void Edit(string newContent)
    {
        Content = newContent;
    }

    public void ChangeAuthor(string newAuthor)
    {
        Author = newAuthor;
    }

    public void Rename(string newTitle)
    {
        Title = newTitle;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}
