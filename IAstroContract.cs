using System.ServiceModel;
//Author: Lan Song ID:30072745 26/9/2023 Murdoch
namespace MalinAstrionics
{
    [ServiceContract]
    public interface IAstroContract
    {
        //7.1 Create the ServiceContract called “IAstroContract.cs” which will need to
        //be identical to the server without a reference to the AstroMath.DLL. 
        [OperationContract]
        double GetStarVelocity(double x, double y);
        [OperationContract]
        double GetStarDistance(double x);
        [OperationContract]
        double GetTempKelvin(double x);
        [OperationContract]
        double GetSchRadius(double x);
    }
}
