using Minio;
using Minio.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMinIO.Sources
{

    class BucketExists
    {
        // Check if a bucket exists
        public async static Task Run(MinioClient minio,
                                     string bucketName = "my-bucket-name")
        {
            try
            {
                Console.WriteLine("Running example for API: BucketExistsAsync");
                bool found = await minio.BucketExistsAsync(bucketName);
                Console.WriteLine((found ? "Found" : "Couldn't find ") + "bucket " + bucketName);
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"[Bucket]  Exception: {e}");
            }
        }
    }


    public class MakeBucket
    {
        // Make a bucket
        public async static Task Run(MinioClient minio,
                                     string bucketName = "my-bucket-name")
        {
            try
            {
                Console.WriteLine("Running example for API: MakeBucketAsync");
                await minio.MakeBucketAsync(bucketName);
                Console.WriteLine($"Created bucket {bucketName}");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"[Bucket]  Exception: {e}");
            }
        }
    }


    class ListBuckets
    {
        // List all buckets on host
        public async static Task Run(MinioClient minio)
        {
            try
            {
                Console.WriteLine("Running example for API: ListBucketsAsync");
                var list = await minio.ListBucketsAsync();
                foreach (var bucket in list.Buckets)
                {
                    Console.WriteLine($"{bucket.Name} {bucket.CreationDateDateTime}");
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"[Bucket]  Exception: {e}");
            }
        }
    }


    class ListenBucketNotifications
    {
        // Listen for notifications from a specified bucket (a Minio-only extension)
        public static void Run(MinioClient minio,
                                     string bucketName = "my-bucket-name",
                                     IList<EventType> events = null,
                                     string prefix = "",
                                     string suffix = "",
                                     bool recursive = true)
        {
            try
            {
                Console.WriteLine("Running example for API: ListenBucketNotifications");
                Console.WriteLine();
                events = events ?? new List<EventType> { EventType.ObjectCreatedAll };
                IObservable<MinioNotificationRaw> observable = minio.ListenBucketNotificationsAsync(bucketName, events, prefix, suffix);

                IDisposable subscription = observable.Subscribe(
                    notification => Console.WriteLine($"Notification: {notification.json}"),
                    ex => Console.WriteLine($"OnError: {ex}"),
                    () => Console.WriteLine($"Stopped listening for bucket notifications\n"));

                // subscription.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine($"[Bucket]  Exception: {e}");
            }
        }
    }

    public class BucketLib
    {
    }
}
