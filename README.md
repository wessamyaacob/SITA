- The program run in the beginning by deserialize XML file (which is exists in the application files) to object of type Container , 
After that an object of type IParcelService service intianlized with dependancy object IDepartmentFactory

 - IDepartmentFactory is interface with one method called CreateDepartments responsible for creating list of objects implements IDepartment interface based on the parcel weight and value
 
 ** For extending the departments we can easly create a new class implements IDepartment interface and add the new rule for that class inside the factory class,
 
 In the factory class I used dictionary to hold objects of all the departments concreate implementation so we are no longer need to intialize new object foreach department evey time we need it
