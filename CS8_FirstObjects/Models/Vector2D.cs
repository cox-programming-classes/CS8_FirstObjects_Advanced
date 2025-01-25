using System.Numerics;

namespace CS8_FirstObjects.Models;

/// <summary>
/// Represents a 2D Vector for doing MATH
/// </summary>
public class Vector2D
{
    #region Properties
    /// <summary>
    /// X Coordinate of this Vector
    /// </summary>
    public required double X { get; init; }
    
    /// <summary>
    /// Y Coordinate of this Vector
    /// </summary>
    public required double Y { get; init; }
    
    /// <summary>
    /// Computed Magnitude of this vector.
    /// </summary>
    public double Magnitude => Math.Sqrt(X * X + Y * Y);
    
    /// <summary>
    /// Compute the Angle of this vector!
    /// </summary>
    /// <exception cref="NotImplementedException">TODO: Complete this code to get rid of this exception.</exception>
    public AngleMeasure Angle => throw new NotImplementedException("You need to implement this function.");
    #endregion
    
    #region Constructors
    /// <summary>
    /// The Constructor is a special method that is use exclusively in
    /// initializing a `new` instance of the Type.
    ///
    /// In this case, it is `private` because I (the developer) am requiring you
    /// to use the two variations of the Factory methods.
    /// </summary>
    private Vector2D() { }

    #endregion

    /************************************************************************
     * Factory Methods are used in lieu of Constructors in some circumstances
     * In this case, I have chosen this method because there are two distinct
     * implementations of constructing a Vector2D and I want you to be able
     * be clear in your code which version you are using~
     ************************************************************************/
    #region Factory Methods    

    /// <summary>
    /// Create a new Vector using rectangular coordinates.
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns>a new Vector2D object with the given coordinates</returns>
    public static Vector2D FromRectangular(double x, double y) 
        => new() { X = x, Y = y };
    
    /// <summary>
    /// Create a new Vector using polar coordinates.
    /// </summary>
    /// <param name="r">Length of this vector</param>
    /// <param name="angle">Angle measured anti-clockwise from the positive x-axis</param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException">TODO: Implement this method by calculating X and Y</exception>
    public static Vector2D FromPolar(double r, AngleMeasure angle)
        => throw new NotImplementedException("You need to implement this function.");
    
    #endregion
    
    #region Arithmetic Operators

    /// <summary>
    /// Add Two Vectors Together
    /// </summary>
    /// <param name="a">left side of +</param>
    /// <param name="b">right side of +</param>
    /// <returns>sum</returns>
    public static Vector2D operator +(Vector2D a, Vector2D b) 
        => new () { X = a.X + b.X, Y = a.Y + b.Y };
    
    /// <summary>
    /// Subtract b from a
    /// </summary>
    /// <param name="a">left side of -</param>
    /// <param name="b">right side of -</param>
    /// <returns>difference</returns>
    public static Vector2D operator -(Vector2D a, Vector2D b)
        => new () { X = a.X - b.X, Y = a.Y - b.Y };
    
    /// <summary>
    /// Compute the Dot-Product (aka Inner Product) of a and b
    /// </summary>
    /// <param name="a">left side of *</param>
    /// <param name="b">right side of *</param>
    /// <returns>Dot Product</returns>
    /// <exception cref="NotImplementedException">TODO:  Implement this!</exception>
    public static double operator *(Vector2D a, Vector2D b)
        => throw new NotImplementedException("You need to implement this function.");
    
    /// <summary>
    /// Scale the vector a by a given constant factor.
    /// </summary>
    /// <param name="factor"></param>
    /// <param name="a"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static Vector2D operator *(double factor, Vector2D a)
        => throw new NotImplementedException("You need to implement this function.");
    
    #endregion
    
    #region Other Mathematical Calculations

    /// <summary>
    /// Rotate this vector by a given angle!
    /// </summary>
    /// <param name="angle"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException">TODO: Implement!</exception>
    public Vector2D Rotate(AngleMeasure angle)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Compute the projection of this vector onto another vector.
    /// (You probably have not learned this in Math class yet!)
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException">TODO: Research and Implement~</exception>
    public Vector2D ProjectOnto(Vector2D other)
    {
        throw new NotImplementedException();
    }
    #endregion
}
