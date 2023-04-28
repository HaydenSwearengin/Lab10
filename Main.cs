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
Car newCar = new Car("Ford","Fiesta","2012",5.0M,15);

Console.WriteLine(newCar.ToString());

Console.WriteLine();

Console.WriteLine(newCar.FillUp());

Console.WriteLine();

Console.WriteLine(newCar.moveCar(300));

Console.WriteLine(newCar.ToString());
