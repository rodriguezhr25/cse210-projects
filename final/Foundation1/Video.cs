// Video class
// The responsability of holding data about videos

public class Video
{

    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>() ;
   
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;


    }
    public void AddComment(Comment comment){
        _comments.Add(comment);
    }
   
    public List<Comment> GetCommentsList(){
        return _comments;
    }
    public string GetVideoString(){
        return $"Title : {_title} - Author : {_author} - Length: {_length} seg  - Number of comments: {_comments.Count()}";
    }

}