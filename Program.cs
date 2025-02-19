﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API_Testing
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            string site = "https://cdn.jsdelivr.net/gh/fawazahmed0/currency-api@1/latest/currencies/eur.json";
            Request request = new Request();
            String data = await request.client(site);
            Parsing parse = new Parsing();
            parse.main(data);


            
                      
        }
    }
    class Request
    { 
        public async Task<string> client(string Site)
        {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(Site);
            return response;
            
        } 
    }

    class Parsing
    {
        public void main(string response)
        {
            dynamic data = JsonConvert.DeserializeObject(response);
            Console.WriteLine("Today: " + data["date"]);
            foreach(var n in data["eur"])
            {
                Console.WriteLine(n);
            }
        }
    }
} /* Output:

{
  "date": "2021-12-26",
  "eur": {
    "ada": 0.773518,
    "aed": 4.165371,
    "afn": 117.377534,
    "all": 120.492072,
    "amd": 542.036945,
    "ang": 2.043896,
    "aoa": 639.942633,
    "ars": 115.930958,
    "aud": 1.57165,
    "awg": 2.04127,
    "azn": 1.932368,
    "bam": 1.958029,
    "bbd": 2.289772,
    "bch": 0.002491,
    "bdt": 97.211085,
    "bgn": 1.95937,
    "bhd": 0.427374,
    "bif": 2270.34552,
    "bmd": 1.134039,
    "bnb": 0.002078,
    "bnd": 1.537627,
    "bob": 7.830595,
    "brl": 6.435513,
    "bsd": 1.134074,
    "btc": 2.2E-05,
    "btn": 85.058035,
    "bwp": 13.179002,
    "byn": 2.855842,
    "byr": 22227.158936,
    "bzd": 2.285867,
    "cad": 1.452988,
    "cdf": 2270.34593,
    "chf": 1.043811,
    "clf": 0.035568,
    "clp": 981.420239,
    "cny": 7.22111,
    "cop": 4526.515556,
    "crc": 728.818589,
    "cuc": 1.134039,
    "cup": 30.052026,
    "cve": 111.02681,
    "czk": 25.070312,
    "djf": 201.541808,
    "dkk": 7.450072,
    "doge": 5.913753,
    "dop": 64.984826,
    "dzd": 157.439775,
    "egp": 17.810092,
    "ern": 17.010669,
    "etb": 55.458889,
    "etc": 0.029687,
    "eth": 0.000277,
    "eur": 1,
    "fjd": 2.416682,
    "fkp": 0.855495,
    "gbp": 0.847088,
    "gel": 3.481942,
    "ggp": 0.855495,
    "ghs": 6.974781,
    "gip": 0.855495,
    "gmd": 59.594177,
    "gnf": 10603.262447,
    "gtq": 8.753504,
    "gyd": 237.33657,
    "hkd": 8.845786,
    "hnl": 27.630899,
    "hrk": 7.526053,
    "htg": 113.887916,
    "huf": 369.855828,
    "idr": 16091.272329,
    "ils": 3.574275,
    "imp": 0.855495,
    "inr": 85.500894,
    "iqd": 1656.263552,
    "irr": 47913.136371,
    "isk": 147.493514,
    "jep": 0.855495,
    "jmd": 174.383863,
    "jod": 0.804078,
    "jpy": 129.741406,
    "kes": 128.316918,
    "kgs": 96.1539,
    "khr": 4621.208187,
    "kmf": 493.732153,
    "kpw": 1020.634761,
    "krw": 1346.127078,
    "kwd": 0.343183,
    "kyd": 0.945061,
    "kzt": 491.471832,
    "lak": 12655.872525,
    "lbp": 1714.809623,
    "link": 0.051495,
    "lkr": 229.645932,
    "lrd": 162.536144,
    "lsl": 17.600714,
    "ltc": 0.007206,
    "ltl": 3.348522,
    "lvl": 0.685969,
    "lyd": 5.220848,
    "mad": 10.50163,
    "mdl": 20.214504,
    "mga": 4485.123536,
    "mkd": 61.67421,
    "mmk": 2016.347807,
    "mnt": 3241.518877,
    "mop": 9.110032,
    "mro": 404.851628,
    "mur": 49.538137,
    "mvr": 17.521327,
    "mwk": 919.705794,
    "mxn": 23.381388,
    "myr": 4.757336,
    "mzn": 72.38612,
    "nad": 17.600709,
    "ngn": 466.0223,
    "nio": 40.156738,
    "nok": 10.032051,
    "npr": 136.092856,
    "nzd": 1.663667,
    "omr": 0.436478,
    "pab": 1.134074,
    "pen": 4.540128,
    "pgk": 4.003582,
    "php": 56.718462,
    "pkr": 201.976496,
    "pln": 4.627727,
    "pyg": 7729.681767,
    "qar": 4.129079,
    "ron": 4.958475,
    "rsd": 117.804366,
    "rub": 83.536132,
    "rwf": 1139.708915,
    "sar": 4.257849,
    "sbd": 9.182524,
    "scr": 15.077782,
    "sdg": 496.146112,
    "sek": 10.352077,
    "sgd": 1.541276,
    "shp": 1.562029,
    "sll": 12854.329289,
    "sos": 664.547074,
    "srd": 23.323818,
    "std": 23472.311914,
    "svc": 9.923145,
    "syp": 2849.264103,
    "szl": 17.6007,
    "thb": 37.899993,
    "theta": 0.225231,
    "tjs": 12.80139,
    "tmt": 3.969136,
    "tnd": 3.257531,
    "top": 2.583624,
    "trx": 13.89941,
    "try": 12.464678,
    "ttd": 7.71016,
    "twd": 31.406413,
    "tzs": 2615.093672,
    "uah": 30.862129,
    "ugx": 4013.853455,
    "usd": 1.134039,
    "usdt": 1.130807,
    "uyu": 50.351553,
    "uzs": 12247.618569,
    "vef": 242491751898.406,
    "vnd": 25912.78478,
    "vuv": 128.432894,
    "wst": 2.948695,
    "xaf": 656.694581,
    "xag": 0.049643,
    "xau": 0.000628,
    "xcd": 3.064797,
    "xdr": 0.81031,
    "xlm": 3.88641,
    "xof": 655.474758,
    "xpf": 120.151815,
    "xrp": 1.226023,
    "yer": 283.793603,
    "zar": 17.667689,
    "zmk": 10207.713412,
    "zmw": 18.740249,
    "zwl": 365.160006
  }
}

*/

