namespace Assignment3.DataEntity;

public class Ball
{
    private int size;
    private Color color;
    private int throwCount;

    // Constructor
    public Ball(int size, Color color)
    {
        this.size = size;
        this.color = color;
        this.throwCount = 0;
    }

    // Pop method to change the ball’s size to 0
    public void Pop()
    {
        size = 0;
    }

    // Throw method to add 1 to the throw count if the ball hasn’t been popped
    public void Throw()
    {
        if (size > 0)
        {
            throwCount++;
        }
    }

    // Method to return the number of times the ball has been thrown
    public int GetThrowCount() => throwCount;  
}