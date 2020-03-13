### Back-End BDD
|Behavior|Input|Output|
|:-:|:-:|:-:|
|**Vendors**|||
|Create new Vendor object with name, description, and orderList|`Vendor epicodus = new Vendor("Epicodus", "Coding Bootcamp interested in giving free bread to students")`|`epicodus.Name => "Epicodus; epicodus.Description => "Coding Bootcamp interested in giving free bread to students"`|
|Upon using Vendor constructor, add Vendor to static list of vendors stored in Vendor class|`Vendor epicodus = new Vendor("Epicodus", "Coding Bootcamp interested in giving free bread to students")`|*add Vendor to _allVendors*|
|Each new instance of Vendor recieves a unique ID based on the static CurrentId property which increments every instantiation.|`Vendor epicodus = new Vendor("Epicodus", "Coding Bootcamp interested in giving free bread to students")`|`epicodus.Id => 1`|
|Vendor.GetAll() returns full list of all instantiated vendors|`Vendor.GetAll()`|`List<Vendor> { epicodus, square, google }`|
|Vendor.Find(id) returns specific vendor object based on id passed into method|`Vendor.Find(1)`|`epicodus`|
|Vendor.Delete(id) deletes specific vendor object based on id passed into method|`Vendor.Find(1)`|`_allVendors.RemoveAt(1)`|
|**Orders**|||
|Create new Order object with Title, description, and date|`Order cater = new Order("Cater", "30 Breads, 30 Pastries", "3/13/2020")`|`cater.Title => "cater; cater.Description => "Catering to students"`|
|Calculate price of Order based on number of bread and pastries (everything is $2)|`Order cater = new Order("Cater", "30 Breads, 30 Pastries", "3/13/2020")`|`cater.Price => 120`|
|Upon using Order constructor, add Order to static list of Orders stored in Order class|`Order cater = new Order("Cater", "Catering to students")`|*add Order to _allOrders*|
|Each new instance of Order recieves a unique ID based on the static CurrentId property which increments every instantiation.|`Order cater = new Order("Cater", "Catering to students")`|`Cater.Id => 1`|
|Order.GetAll() returns full list of all instantiated Orders|`Order.GetAll()`|`List<Order> { cater, square, google }`|
|Order.Find(id) returns specific Order object based on id passed into method|`Order.Find(1)`|`cater`|
|Order.Delete(id) deletes specific Order object based on id passed into method|`Order.Find(1)`|`_allOrders.RemoveAt(1)`|


### Front-End BDD
|Behavior|Input|Output|
|:-:|:-:|:-:|
|**Home Page**|||
|Visitting "/" root route will display splash page with link to Vendors page|*visits '/' route*|*show Home/Index.cshtml*|
|User clicks link to Vendors page, redirect to "/vendors"|*user clicks /vendors link*|*redirect to Vendor/Index.cshtml*|
|**Vendors Page**|||
|Visitting "/vendors" route will display a list of all vendors with links to more info for each vendor and add a new vendor|*visits '/vendors' route*|*show Vendor/Index.cshtml*|
|User clicks link to add new vendor, redirect to "/vendors/new" route with add new vendor form|*user clicks /vendors/new link*|*redirect to Vendor/New.cshtml*|
|User clicks link to specific vendor, redirect to "/vendors/:id" route to display specific vendor information|*user clicks /vendors/:id link*|*redirect to Vendor/Show.cshtml*|
|**New Vendor Form**|||
|Visitting "/vendors/new" route will display a form to add a new vendor with input fields for name and desciription with a submit button.|*visits '/vendors' route*|*show Vendor/Index.cshtml*|
|User clicks submit button, send form data through post request and redirect to "/vendors" route|*user clicks submit*|*redirect to Vendor/Index.cshtml*|
|**Vendor More Info Page**|||
|Visitting "/vendors/:id" route will display all information about the specific vendor including: name, description, list of orders made, and link to add new order.|*visits '/vendors/:id' route*|*show Vendor/Show.cshtml*|
|User clicks link to add new order, redirect to "/vendors/:id/order/new" route and display form to add new order|*user clicks add new order link*|*redirect to Order/New.cshtml*|
|**New Order Form**|||
|Visitting "/vendors/:id/Order/new" route will display a form to add a new order with input fields for title, description, price, date, with a submit button.|*visits '/vendors/:id/order/new' route*|*show Order/New.cshtml*|
|User clicks submit button, send form data through post request and redirect to "/vendors/:id" route|*user clicks submit*|*redirect to Vendor/Show.cshtml*|