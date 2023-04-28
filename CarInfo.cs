/**       
 *--------------------------------------------------------------------
 * 	   File name: Lab 10
 * 	Project name: Lab 10 work
 *--------------------------------------------------------------------
 * Author’s name and email:	Hayden Swearengin				
 *          Course-Section: CSCI 1250
 *           Creation Date:	4/17/2023 		
 * -------------------------------------------------------------------
 */
public class Car { 
    //Properties of the Car
    public string carMake = "";
    public string carModel = "";
    public string carYear = "";
    public int mileage = 0;
    public  decimal carFuel = 0;
    FuelGauge newGauge = new FuelGauge();
    Odometer newOdometer = new Odometer();
    
    
    
    //Constructor for the Car creating the Fuel Gauge and Odometer
    public Car(string _carMake, string _carModel, string _carYear, decimal _carFuel, int _mileage)
    {
        carMake = _carMake;
        carModel = _carModel;
        carYear = _carYear;
        carFuel = _carFuel;
        mileage = _mileage;
    }
    public class FuelGauge {
        public decimal maxFuel = 15.0M;
        public decimal carFuel = 0;

        public FuelGauge(decimal _carFuel)
        {
            carFuel = _carFuel;
        }

        public FuelGauge()
        {
        }

        public void FuelingCar()
        {
            carFuel += 0.5M;
        }

        public void CarRunning()
        {
            if (carFuel > 0){carFuel -= 0.1M;}
        }

        public decimal CarFuel 
        {
            get {return carFuel;}
            set {carFuel = value;}
        }

    }
    public class Odometer 
    {
        public int mileage = 20;
        
        public void MileageUp(){
            if (mileage >= 999999)
            {
            }
            mileage +=1; 
        }

    }
    
    //Getters and Setters
    public string CarMake 
    {
        get {return carMake;}
        set {carMake = value;}
    }
    public string CarModel 
    {
        get {return carModel;}
        set {carModel = value;}
    }
    public string CarYear 
    {
        get {return carYear;}
        set {carYear = value;}
    }

    public bool moveCar(int miles)
    {
    decimal fuelForMileage = (miles % 3) * 0.1M;
    if ((newGauge.carFuel > fuelForMileage))
    {
        newGauge.carFuel -= fuelForMileage;
        return true;
    }
    else 
    {
        return false; 
    }
    }

    public decimal FillUp()
    {
        int count = 0; 
        while(newGauge.carFuel < newGauge.maxFuel)
        {
            newGauge.FuelingCar();
            count += 1; 
        }
        return count * 0.5M;
    }
    
    public override string ToString()
    {
         return $" Your cars make is {carMake}, your cars model is {carModel}, and your car year is {carYear}. You current gas in gallons is {newGauge.carFuel} , Your current gas mileage is at {newOdometer.mileage}";
    }
}

