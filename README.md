## BEC-API Source code

___
This repository contains a fragment of backend source of Blockchain Ensured Certificate application, which validate the given hash-value of the ensured certificate against value stored in the Ethereum public blockchain.

## API Documentation

___

### Validate the given hash-value found in CERTIVATION-issued certificate

**URL** : `/api/certificate-validator/{hash}`

**URL Parameters** : `hash=[string]` where `hash` is the hash-value printed in the downloaded CERTIVATION-issued certificate or shown in the BEC service.

**Method** : `GET`

**Auth required** : `NO`

**Data** : `{}`

__*Notice*__: the relevant logic can be found in `src/Rosen.BEC.API/Controllers/CertificateValidatorController.cs` and `src/Rosen.BEC.API/AppService/CertificateService.cs`

___

### Success Responses

**Condition** : If and only if the certificate in the database contains the given hash-value __*and*__ the hash-value is the same as the hash-value fetched in the Ethereum public blockchain.

**Code** : `200 OK`

### Error Responses

**Condition** : If __*no*__ certificate in the database contains the given hash-value __*or*__ the hash-value cannot be fetched from the Ethereum public blockchain __*or*__ the given hash-value is differenet from the one fetched from the Ethereum public blockchain.

**Code** : `404 NOT FOUND`

___

## IMPORTANT NOTICE

The fragment of code is not runnable at the moment, we plan to publish the full implementation of this repository in a near future.
