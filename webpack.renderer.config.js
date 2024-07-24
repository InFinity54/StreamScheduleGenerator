const rules = require('./webpack.rules');
const webpack = require('webpack');

rules.push({
  test: /\.css$/,
  use: [
    {
      loader: 'style-loader'
    },
    {
      loader: 'css-loader'
    },
    {
      loader: 'postcss-loader',
      options: {
        postcssOptions: {
          plugins: function () {
            return [
              require('autoprefixer')
            ];
          }
        }
      }
    },
  ],
});

module.exports = {
  // Put your normal webpack config below here
  module: {
    rules,
  },
  plugins: [
    new webpack.ProvidePlugin({
      jQuery: 'jquery'
    })
  ]
};
