﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.S3.Transfer;

namespace Cabinet.S3 {
    internal class AmazonS3ClientFactory : IAmazonS3ClientFactory {
        public IAmazonS3 GetS3Client(AmazonS3CabinetConfig config) {
            return new AmazonS3Client(config.AWSCredentials, config.AmazonS3Config);
        }

        public ITransferUtility GetTransferUtility(IAmazonS3 client) {
            return new TransferUtility(client);
        }
    }
}
