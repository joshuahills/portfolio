export const environment = {
  production: false,
  apiUrl: 'https://localhost:4201',
  azureActiveDirectory: {
    // application ID
    clientId: '62c6343c-7223-41c9-834f-bdacb1bfd82f',
    // where Msal will request tokens from - https://login.microsoftonline.com/{tenantId} for single tenant
    authority: 'https://login.microsoftonline.com/b76cc3e0-ccc5-4500-8428-479f650a96a6',
    // this scope is the web API. If you had Graph access within the frontend as well (as an example), you'd add another one 
    apiScope: '62c6343c-7223-41c9-834f-bdacb1bfd82f/access_as_user',
  },
};