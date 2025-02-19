/*global module*/


module.exports = function (grunt) {
  'use strict';

  // Load grunt tasks automatically
  require('load-grunt-tasks')(grunt);

  grunt.initConfig({

    compass: {
      options: {
        bundleExec: true,
        basePath: 'demo',
        sassDir: '.',
        cssDir: '.',
      },
      clean: {
        options: {
          clean: true
        }
      },
      dev: {}
    },


    legacssy: {
      all: {
        files: {
          'demo/styles.legacy.css': 'demo/styles.css',
        }
      }
    },

    watch: {
      compass: {
        options: {
          livereload: true,
          interrupt: true
        },
        files: [
          'src/**/*.scss',
          'demo/**/*.scss'
        ],
        tasks: ['compass:dev', 'legacssy']
      },
    },


    version: {
      options: {
        prefix: '[@\'"]+version[\'"]*?\\s*[:=]*\\s*[\'"]*'
      },
      set: {
        src: ['package.json', 'bower.json', 'README.md', 'Readme.html', 'src/breakpoints.js', 'src/_breakpoints.scss']
      }
    },


    connect: {
      server: {
        options: {
          port: 1331,
          base: ''
        }
      }
    }
  });

  grunt.registerTask('dev', [
    'compass:clean',
    'compass:dev',
    'legacssy',
    'connect:server',
    'watch'
  ]);

  return this.registerTask('default', ['compass:dev']);
};