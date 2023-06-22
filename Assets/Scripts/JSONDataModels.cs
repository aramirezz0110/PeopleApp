// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

using System;
using UnityEngine;

[Serializable] public struct Coordinates
{
    [field:SerializeField] public string latitude { get; set; }
    [field:SerializeField] public string longitude { get; set; }
}

[Serializable] public struct Dob
{
    [field:SerializeField] public DateTime date { get; set; }
    [field:SerializeField] public int age { get; set; }
}

[Serializable] public struct Id
{
    [field:SerializeField] public string name { get; set; }
    [field:SerializeField] public string value { get; set; }
}

[Serializable] public struct Info
{
    [field:SerializeField] public string seed { get; set; }
    [field:SerializeField] public int results { get; set; }
    [field:SerializeField] public int page { get; set; }
    [field:SerializeField] public string version { get; set; }
}

[Serializable] public struct Location
{
    [field:SerializeField] public Street street { get; set; }
    [field:SerializeField] public string city { get; set; }
    [field:SerializeField] public string state { get; set; }
    [field:SerializeField] public string country { get; set; }
    [field:SerializeField] public object postcode { get; set; }
    [field:SerializeField] public Coordinates coordinates { get; set; }
    [field:SerializeField] public Timezone timezone { get; set; }
}

[Serializable] public struct Login
{
    [field:SerializeField] public string uuid { get; set; }
    [field:SerializeField] public string username { get; set; }
    [field:SerializeField] public string password { get; set; }
    [field:SerializeField] public string salt { get; set; }
    [field:SerializeField] public string md5 { get; set; }
    [field:SerializeField] public string sha1 { get; set; }
    [field:SerializeField] public string sha256 { get; set; }
}

[Serializable] public struct Name
{
    [field:SerializeField] public string title { get; set; }
    [field:SerializeField] public string first { get; set; }
    [field:SerializeField] public string last { get; set; }
}

[Serializable] public struct Picture
{
    [field:SerializeField] public string large { get; set; }
    [field:SerializeField] public string medium { get; set; }
    [field:SerializeField] public string thumbnail { get; set; }
}

[Serializable] public struct Registered
{
    [field:SerializeField] public DateTime date { get; set; }
    [field:SerializeField] public int age { get; set; }
}

[Serializable] public struct Result
{
    [field:SerializeField] public string gender { get; set; }
    [field:SerializeField] public Name name { get; set; }
    [field:SerializeField] public Location location { get; set; }
    [field:SerializeField] public string email { get; set; }
    [field:SerializeField] public Login login { get; set; }
    [field:SerializeField] public Dob dob { get; set; }
    [field:SerializeField] public Registered registered { get; set; }
    [field:SerializeField] public string phone { get; set; }
    [field:SerializeField] public string cell { get; set; }
    [field:SerializeField] public Id id { get; set; }
    [field:SerializeField] public Picture picture { get; set; }
    [field:SerializeField] public string nat { get; set; }
}

[Serializable] public struct Root
{
    [field:SerializeField] public Result[] results { get; set; }
    [field:SerializeField] public Info info { get; set; }
}

[Serializable] public struct Street
{
    [field:SerializeField] public int number { get; set; }
    [field:SerializeField] public string name { get; set; }
}

[Serializable] public struct Timezone
{
    [field:SerializeField] public string offset { get; set; }
    [field:SerializeField] public string description { get; set; }
}

