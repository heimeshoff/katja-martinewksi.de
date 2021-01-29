module.exports = {
  purge: [
    './src/**/*.html',
    './src/**/*.js',
  ],
  darkMode: false,
  theme: {
    extend: {
      fontFamily: {
        sans: [ 'Josefin Sans', 'Roboto'],
      }
    },
  },
  variants: {
    extend: {
      borderWidth: ['hover', 'focus'],
    },
  },
  plugins: [],
}