using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;
using System.Text;
using EX1.Models;

/// <summary>
/// DBServices is a class created by me to provides some DataBase Services
/// </summary>
public class DBservices
{
    public SqlDataAdapter da;
    public DataTable dt;

    public DBservices()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    //--------------------------------------------------------------------------------------------------
    // This method creates a connection to the database according to the connectionString name in the web.config 
    //--------------------------------------------------------------------------------------------------
    public SqlConnection connect(String conString)
    {

        // read the connection string from the configuration file
        string cStr = WebConfigurationManager.ConnectionStrings[conString].ConnectionString;
        SqlConnection con = new SqlConnection(cStr);
        con.Open();
        return con;
    }

    //--------------------------------------------------------------------------------------------------
    // This method inserts a airport to the Airports table 
    //--------------------------------------------------------------------------------------------------
    public int insertAirport(Airport airport)
    {

        SqlConnection con;
        SqlCommand cmd;

        try
        {
            con = connect("DBConnectionString"); // create the connection
        }
        catch (Exception ex)
        {
            // write to log
            throw (ex);
        }

        String cStr = BuildInsertCommand(airport);      // helper method to build the insert string

        cmd = CreateCommand(cStr, con);             // create the command

        try
        {
            int numEffected = cmd.ExecuteNonQuery(); // execute the command
            return numEffected;
        }
        catch (Exception ex)
        {
            return 0;
            // write to log
            throw (ex);
        }

        finally
        {
            if (con != null)
            {
                // close the db connection
                con.Close();
            }
        }

    }

    //--------------------------------------------------------------------
    // Build the Insert command String airport
    //--------------------------------------------------------------------
    private String BuildInsertCommand(Airport airport)
    {
        String command;

        StringBuilder sb = new StringBuilder();
        // use a string builder to create the dynamic string
        sb.AppendFormat("Values('{0}', '{1}' ,'{2}', '{3}','{4}','{5}')", airport.Code, airport.Name, airport.Lon, airport.Lat, airport.City, airport.Country);
        String prefix = "INSERT INTO Airports_CS " + "(Code, Name, Lon, Lat, City, Country) ";
        command = prefix + sb.ToString();

        return command;
    }

    //****************************************************************************

    //--------------------------------------------------------------------------------------------------
    // This method inserts a airline to the Airlines table 
    //--------------------------------------------------------------------------------------------------
    public int insertAirline(Airline airline)
    {

        SqlConnection con;
        SqlCommand cmd;

        try
        {
            con = connect("DBConnectionString"); // create the connection
        }
        catch (Exception ex)
        {
            // write to log
            throw (ex);
        }

        String cStr = BuildInsertCommandairline(airline);      // helper method to build the insert string

        cmd = CreateCommand(cStr, con);             // create the command

        try
        {
            int numEffected = cmd.ExecuteNonQuery(); // execute the command
            return numEffected;
        }
        catch (Exception ex)
        {
            return 0;
            // write to log
            throw (ex);
        }

        finally
        {
            if (con != null)
            {
                // close the db connection
                con.Close();
            }
        }

    }

    //--------------------------------------------------------------------
    // Build the Insert command String airline
    //--------------------------------------------------------------------
    private String BuildInsertCommandairline(Airline airline)
    {
        String command;

        StringBuilder sb = new StringBuilder();
        // use a string builder to create the dynamic string
        sb.AppendFormat("Values('{0}', '{1}' )", airline.Code, airline.Name);
        String prefix = "INSERT INTO Airlines_CS " + "(Code, Name) ";
        command = prefix + sb.ToString();

        return command;
    }

    //****************************************************************************

    //--------------------------------------------------------------------------------------------------
    // This method inserts a MyFlight to the MyFlight table 
    //--------------------------------------------------------------------------------------------------
    public int insertMyFlight(MyFlight myFlight)
    {

        SqlConnection con;
        SqlCommand cmd;

        try
        {
            con = connect("DBConnectionString"); // create the connection
        }
        catch (Exception ex)
        {
            // write to log
            throw (ex);
        }

        String cStr = BuildInsertCommandmyFlight(myFlight);      // helper method to build the insert string

        cmd = CreateCommand(cStr, con);             // create the command

        try
        {
            int numEffected = cmd.ExecuteNonQuery(); // execute the command
            return numEffected;
        }
        catch (Exception ex)
        {
            return 0;
            // write to log
            throw (ex);
        }

        finally
        {
            if (con != null)
            {
                // close the db connection
                con.Close();
            }
        }

    }




    //--------------------------------------------------------------------
    // Build the Insert command String myflight
    //--------------------------------------------------------------------
    private String BuildInsertCommandmyFlight(MyFlight myFlight)
    {
        String command;

        StringBuilder sb = new StringBuilder();
        // use a string builder to create the dynamic string
        sb.AppendFormat("Values('{0}', '{1}' ,'{2}', '{3}','{4}','{5}','{6}','{7}','{8}','{9}')", myFlight.Id, myFlight.AirportOut, myFlight.Airportin, myFlight.TimeOut, myFlight.TimeIn, myFlight.Duration, myFlight.Cost, myFlight.Stop, myFlight.Name, myFlight.Email);
        String prefix = "INSERT INTO MyFlights_CS " + "(Id, AirportOut, Airportin, TimeO, TimeI, Duration, Cost, Stops, Name, Email) ";
        command = prefix + sb.ToString();

        return command;
    }


    //****************************************************************************

    //--------------------------------------------------------------------------------------------------
    // This method inserts a leg to the leg table 
    //--------------------------------------------------------------------------------------------------
    public int insertMyLeg(Leg leg)
    {

        SqlConnection con;
        SqlCommand cmd;

        try
        {
            con = connect("DBConnectionString"); // create the connection
        }
        catch (Exception ex)
        {
            // write to log
            throw (ex);
        }

        String cStr = BuildInsertCommandmyLeg(leg);      // helper method to build the insert string

        cmd = CreateCommand(cStr, con);             // create the command

        try
        {
            int numEffected = cmd.ExecuteNonQuery(); // execute the command
            return numEffected;
        }
        catch (Exception ex)
        {
            return 0;
            // write to log
            throw (ex);
        }

        finally
        {
            if (con != null)
            {
                // close the db connection
                con.Close();
            }
        }

    }

    //--------------------------------------------------------------------
    // Build the Insert command String leg
    //--------------------------------------------------------------------
    private String BuildInsertCommandmyLeg(Leg leg)
    {
        String command;

        StringBuilder sb = new StringBuilder();
        // use a string builder to create the dynamic string
        sb.AppendFormat("Values('{0}', '{1}' ,'{2}', '{3}','{4}','{5}','{6}','{7}','{8}','{9}')", leg.Id, leg.Flightid, leg.Legnum, leg.Flightno, leg.AirportOut, leg.Airportin, leg.Airlinecode, leg.TimeOut, leg.TimeIn, leg.Duration);
        String prefix = "INSERT INTO Legs_CS " + "(Id, FlightId, LegNum, FlightNo, AirportOut, AirportIn, AirlineCode, TimeO, TimeI, Duration) ";
        command = prefix + sb.ToString();

        return command;
    }



    //---------------------------------------------------------------------------------
    // Create the SqlCommand
    //---------------------------------------------------------------------------------
    private SqlCommand CreateCommand(String CommandSTR, SqlConnection con)
    {

        SqlCommand cmd = new SqlCommand(); // create the command object

        cmd.Connection = con;              // assign the connection to the command object

        cmd.CommandText = CommandSTR;      // can be Select, Insert, Update, Delete 

        cmd.CommandTimeout = 10;           // Time to wait for the execution' The default is 30 seconds

        cmd.CommandType = System.Data.CommandType.Text; // the type of the command, can also be stored procedure

        return cmd;
    }


   
    //---------------------------------------------------------------------------------
    // Read flight using a DataSet
    //---------------------------------------------------------------------------------
    public DBservices readFlight()
    {
        SqlConnection con = null;
        try
        {
            con = connect("DBConnectionString");
            da = new SqlDataAdapter("select * from MyFlights_CS", con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
        }

        catch (Exception ex)
        {
            // write errors to log file
            // try to handle the error
            throw ex;
        }

        finally
        {
            if (con != null)
            {
                con.Close();
            }
        }

       
        return this;

    }

    //****************************************************************************

    //--------------------------------------------------------------------------------------------------
    // This method inserts a Discount to the Discount table 
    //--------------------------------------------------------------------------------------------------
    public int insertDiscount(Discount discount)
    {

        SqlConnection con;
        SqlCommand cmd;

        try
        {
            con = connect("DBConnectionString"); // create the connection
        }
        catch (Exception ex)
        {
            // write to log
            throw (ex);
        }

        String cStr = BuildInsertCommanddiscount(discount);      // helper method to build the insert string

        cmd = CreateCommand(cStr, con);             // create the command

        try
        {
            int numEffected = cmd.ExecuteNonQuery(); // execute the command
            return numEffected;
        }
        catch (Exception ex)
        {
            return 0;
            // write to log
            throw (ex);
        }

        finally
        {
            if (con != null)
            {
                // close the db connection
                con.Close();
            }
        }

    }


    //--------------------------------------------------------------------
    // Build the Insert command String Discount
    //--------------------------------------------------------------------
    private String BuildInsertCommanddiscount(Discount discount)
    {
        String command;

        StringBuilder sb = new StringBuilder();
        // use a string builder to create the dynamic string
        sb.AppendFormat("Values( '{0}' ,'{1}', '{2}','{3}','{4}','{5}')", discount.Code, discount.CityFrom, discount.CityTo, discount.TimeOut, discount.TimeIn, discount.CompanyDiscount);
        String prefix = "INSERT INTO Discount_CS " + "(Code, CityFrom, CityTo, TimeO, TimeI, CompanyDiscount) ";
        command = prefix + sb.ToString();

        return command;
    }



    //---------------------------------------------------------------------------------
    // Read Discount using a DataSet
    //---------------------------------------------------------------------------------
    public DBservices readDiscount()
    {
        SqlConnection con = null;
        try
        {
            con = connect("DBConnectionString");
            da = new SqlDataAdapter("select * from Discount_CS", con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dt = ds.Tables[0];
        }

        catch (Exception ex)
        {
            // write errors to log file
            // try to handle the error
            throw ex;
        }

        finally
        {
            if (con != null)
            {
                con.Close();
            }
        }


        return this;

    }

    public int deleterow(int id)
    {

        SqlConnection con;
        SqlCommand cmd;

        try
        {
            con = connect("DBConnectionString"); // create the connection
        }
        catch (Exception ex)
        {
            // write to log
            throw (ex);
        }

        String cStr = BuildDeleteCommand(id);      // helper method to build the insert string

        cmd = CreateCommand(cStr, con);             // create the command

        try
        {
            int numEffected = cmd.ExecuteNonQuery(); // execute the command
            return numEffected;
        }
        catch (Exception ex)
        {
            return 0;
            // write to log
            throw (ex);
        }

        finally
        {
            if (con != null)
            {
                // close the db connection
                con.Close();
            }
        }

    }

    //--------------------------------------------------------------------
    // Build the Delete command
    //--------------------------------------------------------------------
    private String BuildDeleteCommand(int id)
    {

        String prefix = "DELETE FROM Discount_CS WHERE Id=" + id;


        return prefix;
    }



    //****************************************************************************

    //--------------------------------------------------------------------------------------------------
    // This method inserts a payment to the payment table 
    //--------------------------------------------------------------------------------------------------
    public int insertPayments(Payment payment)
    {

        SqlConnection con;
        SqlCommand cmd;

        try
        {
            con = connect("DBConnectionString"); // create the connection
        }
        catch (Exception ex)
        {
            // write to log
            throw (ex);
        }

        String cStr = BuildInsertCommandmyPayment(payment);      // helper method to build the insert string

        cmd = CreateCommand(cStr, con);             // create the command

        try
        {
            int numEffected = cmd.ExecuteNonQuery(); // execute the command
            return numEffected;
        }
        catch (Exception ex)
        {
            return 0;
            // write to log
            throw (ex);
        }

        finally
        {
            if (con != null)
            {
                // close the db connection
                con.Close();
            }
        }

    }

    //--------------------------------------------------------------------
    // Build the Insert command String payment
    //--------------------------------------------------------------------
    private String BuildInsertCommandmyPayment(Payment payment)
    {
        String command;

        StringBuilder sb = new StringBuilder();
        // use a string builder to create the dynamic string
        sb.AppendFormat("Values('{0}', '{1}' ,'{2}', '{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", payment.Name, payment.Email, payment.Owner, payment.Cvv, payment.CardNumber, payment.ExpirationDate, payment.Amount,payment.Id, payment.AirportOut, payment.AirportIn, payment.TimeOut, payment.TimeIn);
        String prefix = "INSERT INTO Payments_CS " + "(Name, Email, Owner, Cvv, CardNumber, ExpirationDate, Amount, id, AirportOut, AirportIn, TimeO, TimeI) ";
        command = prefix + sb.ToString();

        return command;
    }



    //****************************************************************************

    //--------------------------------------------------------------------------------------------------
    // This method inserts a tour to the tour table 
    //--------------------------------------------------------------------------------------------------
    public int insertTours(Tour tour)
    {

        SqlConnection con;
        SqlCommand cmd;

        try
        {
            con = connect("DBConnectionString"); // create the connection
        }
        catch (Exception ex)
        {
            // write to log
            throw (ex);
        }

        String cStr = BuildInsertCommandmyTour(tour);      // helper method to build the insert string

        cmd = CreateCommand(cStr, con);             // create the command

        try
        {
            int numEffected = cmd.ExecuteNonQuery(); // execute the command
            return numEffected;
        }
        catch (Exception ex)
        {
            return 0;
            // write to log
            throw (ex);
        }

        finally
        {
            if (con != null)
            {
                // close the db connection
                con.Close();
            }
        }

    }

    //--------------------------------------------------------------------
    // Build the Insert command String tour
    //--------------------------------------------------------------------
    private String BuildInsertCommandmyTour(Tour tour)
    {
        String command;

        StringBuilder sb = new StringBuilder();
        // use a string builder to create the dynamic string
        sb.AppendFormat("Values('{0}', '{1}' ,'{2}', '{3}','{4}','{5}','{6}')", tour.CompanyName, tour.Email, tour.City, tour.Duration, tour.Price, tour.Description, tour.Restaurant);
        String prefix = "INSERT INTO Tours_CS " + "(CompanyName, Email, City, Duration, Price, Description, Restaurant) ";
        command = prefix + sb.ToString();

        return command;
    }



    public List<Tour> getToursByCity(string city)
    {
        List<Tour> tourList = new List<Tour>();
        SqlConnection con = null;

        try
        {
            con = connect("DBConnectionString"); // create a connection to the database using the connection String defined in the web config file

            String selectSTR = "SELECT * FROM Tours_CS where City ='" + city.ToString() +"'";
            SqlCommand cmd = new SqlCommand(selectSTR, con);

            // get a reader
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection); // CommandBehavior.CloseConnection: the connection will be closed after reading has reached the end

            while (dr.Read())
            {   // Read till the end of the data into a row
                Tour t = new Tour(null,null, null, null, null, null, null);

                t.CompanyName = (string)dr["CompanyName"];
                t.Email = (string)dr["Email"];
                t.City = (string)dr["City"];
                t.Duration = (string)dr["Duration"];
                t.Price = (string)dr["Price"];
                t.Description = (string)dr["Description"];
                t.Restaurant = (string)dr["Restaurant"];

                tourList.Add(t);
            }
            return tourList;
        }
        catch (Exception ex)
        {
            // write to log
            throw (ex);
        }
        finally
        {
            if (con != null)
            {
                con.Close();
            }
        }
    }
     
}





