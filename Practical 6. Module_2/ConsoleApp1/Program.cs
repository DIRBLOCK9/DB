using System;
using System.Collections;
using System.Collections.Generic;

namespace DocumentComparison
{
   
    public class Document : IComparable<Document>
    {
        public string Title { get; }
        public int PageCount { get; }
        public int ConfidentialityLevel { get; } 

        public Document(string title, int pageCount, int confidentialityLevel)
        {
            Title = title;
            PageCount = pageCount;
            ConfidentialityLevel = confidentialityLevel;
        }

        public override string ToString()
        {
            return $"{Title}, Pages: {PageCount}, Confidentiality: {ConfidentialityLevel}";
        }

      
        public int CompareTo(Document? other)
        {
            if (other == null) return 1;
            return PageCount.CompareTo(other.PageCount);
        }
    }

    public class DocumentComparer : IComparer<Document>
    {
        public int Compare(Document? x, Document? y)
        {
            if (x == null || y == null) return 0;

            int result = x.PageCount.CompareTo(y.PageCount);

            if (result == 0)
            {
                result = x.ConfidentialityLevel.CompareTo(y.ConfidentialityLevel);
            }

            return result;
        }
    }

    public class DocumentCollection : IEnumerable<Document>
    {
        private List<Document> documents = new List<Document>();

        public void Add(Document document)
        {
            documents.Add(document);
        }

        public IEnumerator<Document> GetEnumerator()
        {
            return documents.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DocumentCollection docs = new DocumentCollection();
            docs.Add(new Document("Document A", 50, 1)); 
            docs.Add(new Document("Document B", 30, 3)); 
            docs.Add(new Document("Document C", 80, 2)); 
            docs.Add(new Document("Document D", 10, 4)); 

            Console.WriteLine("Documents sorted by page count:");
            foreach (var doc in docs)
            {
                Console.WriteLine(doc);
            }

            List<Document> docList = new List<Document>(docs);
            docList.Sort(new DocumentComparer());

            Console.WriteLine("\nDocuments sorted by page count and confidentiality:");
            foreach (var doc in docList)
            {
                Console.WriteLine(doc);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
