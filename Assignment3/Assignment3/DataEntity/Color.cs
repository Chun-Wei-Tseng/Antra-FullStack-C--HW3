namespace Assignment3.DataEntity;

public class Color
{
    private int red;
    private int green;
    private int blue;
    private int alpha;

    // Constructor with red, green, blue, and alpha
    public Color(int red, int green, int blue, int alpha)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
        this.alpha = alpha;
    }
    // Constructor with red, green, blue, and default alpha to 255
    public Color(int red, int green, int blue) : this(red, green, blue, 255) { }

    // Methods to get and set the red, green, blue, and alpha values
    public int GetRed() => red;
    public void SetRed(int red) => this.red = red;

    public int GetGreen() => green;
    public void SetGreen(int green) => this.green = green;

    public int GetBlue() => blue;
    public void SetBlue(int blue) => this.blue = blue;

    public int GetAlpha() => alpha;
    public void SetAlpha(int alpha) => this.alpha = alpha;

    // Method to get the grayscale value
    public int GetGrayscale() => (red + green + blue) / 3;
}