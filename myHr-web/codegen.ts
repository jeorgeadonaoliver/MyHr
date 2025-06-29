import type { CodegenConfig } from '@graphql-codegen/cli';

const config: CodegenConfig = {
  schema: 'https://localhost:7083/graphql/',
  documents: ['src/**/*.ts'],
  generates: {
    //authentication features
    './src/app/features/authentication/graphQL/': {
      preset: 'client',
      documents:['src/app/features/authentication/graphql/*.graphql'],
      plugins: [],
    },
    // employee feature
    './src/app/features/employees/graphQL/': {
      preset: 'client',
      documents:['src/app/features/employees/graphql/*.graphql'],
      plugins: [],
      	// 	presetConfig: {
        // 	gqlTagName: 'gql', // optional
      	// 		},
    		// },
      },
    // department feauture
      './src/app/features/departments/graphQL/': {
      preset: 'client',
      documents:['src/app/features/departments/graphql/*.graphql'],
      plugins: [],
      }
  },
  
};

export default config;