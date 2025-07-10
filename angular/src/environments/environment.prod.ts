import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'ABP_Ecommerce',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44339/',
    redirectUri: baseUrl,
    clientId: 'ABP_Ecommerce_App',
    responseType: 'code',
    scope: 'offline_access ABP_Ecommerce',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44348',
      rootNamespace: 'ABP_Ecommerce',
    },
  },
} as Environment;
