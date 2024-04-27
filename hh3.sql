SELECT product, category FROM Products
LEFT JOIN Categories ON Products.id = Categories.id_prod
