# Gummi Bear Kingdom

Welcome to a magical land of candy. Welcome to Gummi Bear Kingdom!  

This is the ReadMe for the new official website for Gummi Bear Kingdom (GBK). On the new and improved site, the user will be able to:  

 * Be greeted with a landing page that has general information and access to other areas of the website.  

 * Access a list of products sold by GBK.  

 * View details on each product, including __name__, __cost__, and __description__.  


 Admins will be able to:

 * Add and remove individual products.  

 * Delete all products.  

## Getting Started/Technologies Used

You'll need to have these installed to view the website:

* .NET Core 1.1 SDK  
* .NET runtime  
* Access to command line via GitBash or Terminal  
* An internet browser (Chrome recommended)

## Installation Instructions

1.  Clone the GitHub repo: https://github.com/jamescosborn/gummi-bear-kingdom
2.  Navigate to the project directory with GitBash or Terminal  
3. Type and enter `dotnet restore`
4. Type and enter `dotnet run`
5. In a web browser, go to whichever port is specified after local host. e.g.: `localhost:5000`

## Known Bugs

* There are no known bugs at this time.  

_Please contact the developers should you encounter a bug._

## Contributors

__James Osborn__, web developer  
jamescarlosborn@gmail.com

## Specs

__Description:__  When navigating to the site, user will be greeted with a landing page containing company description and links to other parts of the website.  
__Input:__  User goes to GBK website  
__Output:__   User is greeted with landing page, company description, link to products.

__Description:__ User can click on products to view a list of all GBK's products.  
__Input:__  User clicks 'Products'.  
__Output:__  User sees a list of name of all of GBK's products.

__Description:__  User is able to click and individual product to see its name, cost and description.  
__Input:__  User clicks "Magic Bears."  
__Output:__  
```
Name: Magic Bears  
Cost: $5  
Description: They're delicious.
```

__Description:__  Admins are able to add a product to the list.  
__Input:__  Admin adds "Red Bears."  
__Output:__  Red Bears appears on list.

__Description:__  Admins are able to delete an individual product from the list.  
__Input:__  Admin deletes "Purple Bears."  
__Output:__  "Purple Bears" no longer displays in the product list.  

__Description:__  Admins are able to delete all products from the product list.  
__Input:__  Admin deletes all products.  
__Output:__  No more products are displayed on the list.  

## License
This website uses the MIT license.  
