### Back-End BDD
|Behavior|Input|Output|
|:-:|:-:|:-:|
|**Vendors**|||
||||

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