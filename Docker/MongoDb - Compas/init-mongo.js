db.createUser({
  user: "root",
  pwd: "root",
  roles: [
    {
      role: "readWrite",
      db: "Libros"
    }
  ]
});

db.myCollection.insertOne({ name: "Libros" });
