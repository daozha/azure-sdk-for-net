// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//


namespace Backup.Tests
{
    using Microsoft.AzureStack.Management.Backup.Admin;
    using Microsoft.AzureStack.Management.Backup.Admin.Models;
    using System;
    using Xunit;

    public class BackupLocationTests : BackupTestBase
    {

        private void ValidateBackupLocation(BackupLocation location)
        {
            Assert.NotNull(location);

            // Resource properties
            Assert.NotNull(location.Id);
            Assert.NotNull(location.Type);
            Assert.NotNull(location.Name);
            Assert.NotNull(location.Location);

            // Backup location properties
            // TODO: Check with teams.
        }

        private void AssertSame(BackupLocation expected, BackupLocation given)
        {
            if (expected == null)
            {
                Assert.Null(given);
            }
            else
            {
                Assert.NotNull(given);

                // Resource properties
                Assert.Equal(expected.Id.ToLower(), given.Id.ToLower());
                Assert.Equal(expected.Type, given.Type);
                Assert.Equal(expected.Name, given.Name);
                Assert.Equal(expected.Location, given.Location);

                // Location properties
                Assert.Equal(expected.AvailableCapacity, given.AvailableCapacity);
                Assert.Equal(expected.BackupFrequencyInHours, given.BackupFrequencyInHours);
                Assert.Equal(expected.EncryptionCertBase64, given.EncryptionCertBase64);
                Assert.Equal(expected.IsBackupSchedulerEnabled, given.IsBackupSchedulerEnabled);
                Assert.Equal(expected.LastBackupTime, given.LastBackupTime);
                Assert.Equal(expected.NextBackupTime, given.NextBackupTime);
                Assert.Equal(expected.LastBackupTime, given.LastBackupTime);
                Assert.Equal(expected.Password, given.Password);
                Assert.Equal(expected.Path, given.Path);
                Assert.Equal(expected.UserName, given.UserName);

            }
        }

        [Fact]
        public void TestListBackupLocations()
        {
            RunTest((client) =>
            {
                var backupLocations = client.BackupLocations.List(ResourceGroupName);
                Common.MapOverIPage(backupLocations, client.BackupLocations.ListNext, ValidateBackupLocation);
            });
        }

        [Fact]
        public void TestGetBackupLocation()
        {
            RunTest((client) =>
            {
                var backupLocations = client.BackupLocations.List(ResourceGroupName);
                var backupLocation = backupLocations.GetFirst();
                var result = client.BackupLocations.Get(ResourceGroupName, backupLocation.Name);
                AssertSame(backupLocation, result);
            });
        }

        [Fact]
        public void TestGetAllBackupLocation()
        {
            RunTest((client) =>
            {
                var backupLocations = client.BackupLocations.List(ResourceGroupName);
                Common.MapOverIPage(backupLocations, client.BackupLocations.ListNext, (backupLocation) =>
                {
                    var result = client.BackupLocations.Get(ResourceGroupName, backupLocation.Name);
                    AssertSame(backupLocation, result);
                });
            });
        }

        [Fact]
        public void TestUpdateBackupLocation()
        {
            RunTest((client) =>
            {

                var backupLocation = client.BackupLocations.Get(ResourceGroupName, "local");

                backupLocation.Path = @"\\su1fileserver\SU1_Infrastructure_2\BackupStore";
                backupLocation.UserName = @"azurestack\azurestackadmin";
                backupLocation.Password = "password";
                backupLocation.EncryptionCertBase64 = @"MIIDPzCCAiegAwIBAgIQLeqM7fek06pOGOJ+fU/bfDANBgkqhkiG9w0BAQsFADAhMR8wHQYDVQQDDBZ3d3cuaGFoYS5ub3Rzb211Y2guY29tMB4XDTE4MDgyODA2MzcyMVoXDTE5MDgyODA2NTcyMVowITEfMB0GA1UEAwwWd3d3LmhhaGEubm90c29tdWNoLmNvbTCCASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoCggEBANqODsU5P1j257arMxu3KEFmmW5swahCOgmoyd3EBsnWwTfdOD6OiAep/ubLpjsmWRlzroTBPTnLbZVC6OxNsvdGQx30EeOfGF9JBd7xbhXYeT668GwPuTlVBeDYOSO4qbnHsLJSvoxHkaMEiq6TqrIgnmr/WRG1Kd4iZ+goSth3A+Eck1KpaQ1r1KxSWazNChPU6gQ6+/Slhxydse7mMsbSCJkzPeZ5YppmUBbbk3GOQj/2+aLMYCyPe2kosMZFr37owRP6bL7hKXyyUBUyQWQTau/fMQ369WJO9wWdYb+z5vQbgZV81qeXcJWu6H+VkL1qNrMfPuh6ET5wM5ZDU80CAwEAAaNzMHEwDgYDVR0PAQH/BAQDAgWgMB0GA1UdJQQWMBQGCCsGAQUFBwMCBggrBgEFBQcDATAhBgNVHREEGjAYghZ3d3cuaGFoYS5ub3Rzb211Y2guY29tMB0GA1UdDgQWBBRh/K5ZaNGyX406dYi0U5rrKaguQjANBgkqhkiG9w0BAQsFAAOCAQEAR4EbToyzUSZHz/Q4aajSyrIukcqJr7IiWs+uDVuqEAUqb6BD5wbkNMvZlSmahLPGm2bXnuboB6W4xEctph1bMVx/up7G3p8aKM4kC/34wBOJCIlJqp9MCUW9zDDR5+BOiS2N1gDgqdBKDFcPjUC9bd7UM6xLL6T1EL5tka1UF36YuHlntfWUGsfWdaM0iC6eG4H2WVx7jhuRGYkiaLJ1v7BVqgXSUV4kiUPTC6T6UuGp7Exkoy6v4+4e1Aj6yCHib70lvSGM+i06j+AFt+tMmEprOgOglC/ZjyKuN3qm7Dt21IDf9BHf5eOtPXTQ4foN55qHJ7qhzGQOje5P5jUrfg==";
                backupLocation.IsBackupSchedulerEnabled = false;
                backupLocation.BackupFrequencyInHours = 10;
                backupLocation.BackupRetentionPeriodInDays = 6;

                var result = client.BackupLocations.Update(ResourceGroupName, "local", backupLocation);
                Assert.NotNull(result);

                result.Path = null;
                result.UserName = null;
                result.Password = null;
                result.EncryptionCertBase64 = null;

                result = client.BackupLocations.Update(ResourceGroupName, "local", result);

                Assert.Equal(result.Path, backupLocation.Path);
                Assert.Equal(result.UserName, backupLocation.UserName);
                Assert.Null(result.Password);
                Assert.Null(result.EncryptionCertBase64);
                Assert.Equal(result.IsBackupSchedulerEnabled, backupLocation.IsBackupSchedulerEnabled);
                Assert.Equal(result.BackupFrequencyInHours, backupLocation.BackupFrequencyInHours);
                Assert.Equal(result.BackupRetentionPeriodInDays, backupLocation.BackupRetentionPeriodInDays);

            }, null, null, System.Net.HttpStatusCode.OK, false);
        }

        [Fact]
        public void TestCreateBackup()
        {
            RunTest((client) =>
            {
                var backup = client.BackupLocations.CreateBackup(ResourceGroupName, "local");
                Assert.NotNull(backup);
            });
        }


    }
}
