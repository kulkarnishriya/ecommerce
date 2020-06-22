# ecommerce
Azure hosted ecommerce website .net core 3.0

This project demo has all you need to design fully functional a .NetCore E-Commerce application hosted in Azure.
It follows a service based architecture with .Net MVC core in front End followed by >net Core web APIs for the data fetching.

The Web folder contains all the views and controllers from UI perspective. This app has Produc overview page, Add to Cart functionality,
View Products history, Add new product for sell and Admin tab for managing products and prices.

The Services folder contains two primary services(API):
Products service API and Blob API (To upload images to Azure blob storage),since the images for the site come from Azure Blob storage.

For authentication and authorization, I have used Azure AAD with OpenId connect in the application. Which allows users in Azure AAD to 
successfully access the application.

The application and API services are hosted as Azure WebAP and the ARM templates for the same are included in the repository.

This project also has an PaymentGateway Azure function to replicate the payment gateway and produce the response after a delay.
