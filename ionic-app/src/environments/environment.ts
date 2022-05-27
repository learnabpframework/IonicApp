import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:8100';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'IonicApp',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44367',
    redirectUri: baseUrl,
    clientId: 'IonicApp_MobileApp',
    responseType: 'code',
    scope: 'offline_access IonicApp',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44367',
      rootNamespace: 'IonicApp',
    },
  },
} as Environment;

