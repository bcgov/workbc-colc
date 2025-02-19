/*global module*/
var fs = require('fs')

module.exports = function (grunt) {
  'use strict';

  // Load grunt tasks automatically
  require('load-grunt-tasks')(grunt);

  grunt.initConfig({
    pkg: this.file.readJSON('package.json'),

    info: {
      parentPath: '',
      basePath: '.',
      sourceDir: '<%= info.basePath %>/UI',
      buildDir: '<%= info.basePath %>/UI_build',
      imageDir: 'images',
      scriptsDir: 'scripts',
      stylesDir: 'styles',
      sourceScripts: '<%= info.sourceDir %>',
      sourceImages: '<%= info.sourceDir %>/<%= info.imageDir %>',
      sourceStyles: '<%= info.sourceDir %>',
      sourceTmpl: '<%= info.sourceDir %>',
      buildBower: '<%= info.buildDir %>/bower',
      buildScripts: '<%= info.buildDir %>/<%= info.scriptsDir %>',
      viewsDir: '<%= info.basePath %>/Views'
    },


    clean: {
      options: {
        force: true
      },
      css: ['<%= info.sourceDir %>/*.css'],
      icons: ['<%= info.sourceImages %>/icons_min/**/*.svg'],
      dist: ['<%= info.buildDir %>'],
      requirejs: [
        '<%= info.buildDir %>/**/*.scss',
        '!<%= info.buildDir %>/build.txt'
      ],
      docs: ['<%= info.docsDir %>'],
      distbower: [
        '<%= info.buildBower %>/**/*.*',
        '<%= info.buildBower %>/**/.*',
        '<%= info.buildBower %>/**/docs',
        '<%= info.buildBower %>/**/test',
        '<%= info.buildBower %>/**/examples',
        '<%= info.buildBower %>/**/CNAME',
        '<%= info.buildBower %>/**/Rakefile',
        '!<%= info.buildBower %>/**/*.js',
        '<%= info.buildBower %>/**/Gruntfile.js',
        '!<%= info.buildBower %>/**/fonts'
      ]
    },


    compass: {
      options: {
        bundleExec: true,
        raw: 'cache_path = "/tmp/.sass-cache"\n',
        require: ['compass/import-once/activate'],

        extensionsDir: '<%= info.basePath %>/sass-extensions',
        sassDir: '<%= info.sourceDir %>',
        cssDir: '<%= info.sourceDir %>',
        imagesDir: '<%= info.sourceImages %>',
        javascriptsDir: '<%= info.sourceScripts %>',
        fontsDir: '<%= info.sourceDir %>/fonts',
        httpPath: '/<%= info.parentPath %>',

        relativeAssets: false,
        outputStyle: 'expanded'
      },
      clean: {
        options: {
          clean: true
        }
      },
      dev: {
        options: {
          sourcemap: true
        }
      }
    },

    svgmin: {
      options: {
        plugins: [{
          removeXMLProcInst: false
        }]
      },
      welcomebc: {
        expand: true,
        cwd: '<%= info.sourceImages %>/icons/welcomebc/',
        src: ['*.svg'],
        dest: '<%= info.sourceImages %>/icons_min/welcomebc/',
        ext: '.svg'
      },
      workbc: {
        expand: true,
        cwd: '<%= info.sourceImages %>/icons/workbc/',
        src: ['*.svg'],
        dest: '<%= info.sourceImages %>/icons_min/workbc/',
        ext: '.svg'
      }
    },


    grunticon: {
      welcomebc: {
        files: [{
          expand: true,
          cwd: '<%= info.sourceImages %>/icons_min/welcomebc/',
          src: ['*.svg', '*.png'],
          dest: '<%= info.sourceImages %>/grunticons/welcomebc/'
        }],
        options: {
          //tmpPath: '/tmp',
          colors: {
            white: 'white'
          }
        }
      },
      workbc: {
        files: [{
          expand: true,
          cwd: '<%= info.sourceImages %>/icons_min/workbc/',
          src: ['*.svg', '*.png'],
          dest: '<%= info.sourceImages %>/grunticons/workbc/'
        }],
        options: {
          //tmpPath: '/tmp',
          colors: {
            white: 'white'
          }
        }
      }
    },


    legacssy: {
      all: {
        files: [{
          expand: true,
          cwd: '<%= info.sourceDir %>/',
          src: ['*.css', '!*.legacy.css'],
          dest: '<%= info.sourceDir %>/',
          ext: '.legacy.css'
        }]
      }
    },


    jshint: {
      options: {
        force: true,
        jshintrc: '<%= info.sourceDir %>/.jshintrc'
      },
      all: [
        'Gruntfile.js',
        '<%= info.sourceScripts %>/*.js',
        '<%= info.sourceScripts %>/lib/**/*.js',
        '<%= info.sourceScripts %>/base/**/*.js',
        '<%= info.sourceScripts %>/components/**/*.js',
        '<%= info.sourceScripts %>/features/**/*.js',
        '<%= info.sourceScripts %>/pages/**/*.js',
        '!<%= info.sourceScripts %>/components/intention/context.js',
        '<%= info.viewsDir %>/**/*.js'
      ]
    },


    jsbeautifier: {
      files: ['<%= jshint.all %>'],
      options: {
        js: {
          braceStyle: 'end-expand',
          breakChainedMethods: false,
          e4x: false,
          evalCode: false,
          indentChar: ' ',
          indentLevel: 0,
          indentSize: 2,
          indentWithTabs: false,
          jslintHappy: true,
          keepArrayIndentation: false,
          keepFunctionIndentation: true,
          maxPreserveNewlines: 4,
          preserveNewlines: true,
          spaceBeforeConditional: true,
          spaceInParen: false,
          unescapeStrings: false,
          wrapLineLength: 0
        }
      }
    },


    requirejs: {
      compile: {
        options: {
          baseUrl: '.',
          appDir: '<%= info.sourceDir %>',
          dir: '<%= info.buildDir %>',
          mainConfigFile: '<%= info.sourceScripts %>/main.js',
          optimize: 'none',
          preserveLicenseComments: true,
          useStrict: true,
          wrap: true,
          removeCombined: false
        }
      }
    },


    concat: {
      requirejs: {
        src: ['<%= info.buildDir %>/vendor/require.js', '<%= info.buildDir %>/main.js'],
        dest: '<%= info.buildDir %>/main.js',
      }
    },

    filerev: {
      files: {
        src: [
          '<%= info.buildDir %>/vendor/modernizr-custom.js',
          '<%= info.buildDir %>/*.js',
          '<%= info.buildDir %>/*.css',
          '<%= info.buildDir %>/images/grunticons/**/*.css'
        ]
      }
    },

    filerev_assets: {
      dist: {
        options: {
          dest: '<%= info.buildDir %>/filerev.json',
          cwd: '<%= info.basePath %>/'
        }
      }
    },

    useminPrepare: {
      options: {
        dest: '<%= info.buildDir %>'
      },
      html: '<%= info.sourceDir %>/index.html'
    },


    uglify: {
      dist: {
        files: [{
          expand: true,
          cwd: '<%= info.buildDir %>/',
          src: ['*.js', 'components/**/*.js'],
          dest: '<%= info.buildDir %>/'
        }]
      }
    },

    cssmin: {
      dist: {
        files: [{
          expand: true,
          cwd: '<%= info.buildDir %>/',
          src: ['**/*.css'],
          dest: '<%= info.buildDir %>/'
        }]
      }
    },


    usemin: {
      options: {
        assetsDirs: ['<%= info.buildDir %>']
      },
      html: ['<%= info.buildDir %>/{,*/}*.html'],
      css: ['<%= info.buildDir %>/css/{,*/}*.css']
    },


    watch: {
      compass: {
        options: {
          interrupt: true
        },
        files: [
          '<%= info.sourceStyles %>/*.scss',
          '<%= info.sourceStyles %>/lib/**/*.scss',
          '<%= info.sourceStyles %>/base/**/*.scss',
          '<%= info.sourceStyles %>/components/**/*.scss',
          '<%= info.sourceStyles %>/pages/**/*.scss',
          '<%= info.viewsDir %>/**/*.scss'
        ],
        tasks: ['css']
      },
      // icons: {
      //   options: {
      //     livereload: true
      //   },
      //   files: ['<%= info.sourceImages %>/svg/*.svg'],
      //   tasks: ['icons']
      // },
      js: {
        options: {
          livereload: true
        },
        files: ['<%= jshint.all %>'],
        tasks: ['js']
      },
      justwatch: {
        options: {
          livereload: true
        },
        files: [
          'index.html',
          '<%= info.sourceDir %>/components/**/*.md',
          '<%= info.sourceDir %>/**/*.css'

        ]
      }
    },


    connect: {
      watch: {
        options: {
          port: 1337,
          base: '../'
        }
      },
      root: {
        options: {
          keepalive: true,
          port: 1338,
          base: '../'
        }
      },
      src: {
        options: {
          keepalive: true,
          port: 1339,
          base: '<%= info.sourceDir %>'
        }
      },
      dist: {
        options: {
          keepalive: true,
          port: 1340,
          base: '<%= info.buildDir %>'
        }
      },
    }
  });



  grunt.registerTask('css', [
    'force:clean:css',
    'compass:clean',
    'compass:dev',
    'legacssy'
  ]);


  grunt.registerTask('icons', [
    'force:clean:icons',
    'svgmin',
    'grunticon'
  ]);


  grunt.registerTask('js', [
    'jsbeautifier',
    'jshint'
  ]);


  grunt.registerTask('src', [
    'css',
    'icons',
    'js'
  ]);


  grunt.registerTask('dev', [
    'src',
    'connect:watch',
    'watch'
  ]);


  grunt.registerTask('optimize', [
    // 'useminPrepare',
    'requirejs',
    'concat:requirejs',
    'uglify',
    'cssmin',
    'filerev',
    'filerev_assets',
    // 'usemin',
    'force:clean:requirejs',
    'force:clean:distbower'
  ]);


  grunt.registerTask('build', [
    'force:clean:dist',
    'src',
    'optimize'
  ]);

  this.registerTask('default', ['build']);
};
