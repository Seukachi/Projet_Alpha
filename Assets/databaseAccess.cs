using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MongoDB.Driver;

public class databaseAccess : MonoBehaviour
{
    private const string MONGO_URI = "mongodb+srv://test:test@projetalpha.pzbb4q9.mongodb.net/?retryWrites=true&w=majority";
    private const string DATABASE_NAME = "test";
    private MongoClient client;
    private IMongoDatabase db;


    // Start is called before the first frame update
    void Start()
    {
        //test
        client = new MongoClient(MONGO_URI);
        db = client.GetDatabase(DATABASE_NAME);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
